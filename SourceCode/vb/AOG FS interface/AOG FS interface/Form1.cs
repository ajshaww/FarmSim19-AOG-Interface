using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using vJoyInterfaceWrap;


namespace AOG_FS_interface
{
    public partial class Form_main : Form
    {
        //vjoy settings
        static public vJoy joystick;
        static public uint id = 1;
        bool res;
        int maxval = 32767;//the max val of the joystick
        bool infield = false;
        public bool b1 = false;
        public bool b2 = false;
        public bool b3 = false;
        public bool b4 = false;
        public bool b5 = false;
        public bool b6 = false;
        public bool b7 = false;
        public bool b8 = false;
        public bool pause_udp = false;//when setting keybindings we dont want udp screwing us up, so it will turn this true momentarily

        //other settings
        UdpClient client = new UdpClient(1111);
        UdpClient clientaog = new UdpClient(8888);
        public string data = "";
        public string gamedata = "";//place holder for the text that is coming out of the farm sim game
        public string gamedataspecific = "";//placeholder for the data from the specific vehicle that you are wanting
        public string game_lat = "";
        public string game_lon = "";
        public string game_elev = "";
        public string game_speed = "";
        public string game_compass = "";

        public string aog_autosteer_data = "";//this is a placeholde for the last packet that I recieved from AOG
        public string aog_machine_data = "";//this is a placeholde for the last packet that I recieved from AOG

        public string calculated_lat = "";
        public string calculated_lon = "";
        public string calculated_bearing = "";


        public static int pgnSentenceLength = 10;
        public byte[] autoSteerSettings = new byte[pgnSentenceLength];
        public int ssHeaderHi, ssHeaderLo = 1, data1 = 2, data2 = 3, data3 = 4, data4 = 5,
                    data5 = 6, data6 = 7, data7 = 8, data8 = 9;

            public Form_main()
        {
            InitializeComponent();
            init_vjoy();//init the virtual joystick that will be used as input to the game
        }

        private void timer_to_aog_Tick(object sender, EventArgs e)
        {
            
            try
            {
                sendtoaog();
            }
            catch
            {

            }
        }

        private void Form_main_Load(object sender, EventArgs e)
        {
            cb_vehicle_to_control.Text = Properties.Settings.Default.vehicle_to_control;//gets the last vehicle to control

            tb_steering.Maximum = maxval;
            tb_steering.Value = maxval / 2;

            //start up a udp listener to capture autosteer and machine data that ag open gps is sending out
            try
            {
                //clientaog.BeginReceive(new AsyncCallback(recvfromaog), null);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("I had a problem starting the aog client :(");
            }
            //enable_autosteer();//sends the command to aog to turn on autosteer, might trip a watchdog only sending it once, we will see

        }
        void recvfromaog(IAsyncResult res)
        {
            try
            {
                IPEndPoint RemoteIP = new IPEndPoint(IPAddress.Any, 60240);
                byte[] received = clientaog.EndReceive(res, ref RemoteIP);

                data = Encoding.Unicode.GetString(received);

                this.Invoke(new MethodInvoker(delegate
                {
                    pullDataaog(received);
                }));
                clientaog.BeginReceive(new AsyncCallback(recvfromaog), null);
            }
            catch
            {

            }
           
        }

        private void pullDataaog(byte[] message)
        {

            if (!pause_udp)
            {
                if (message[1].ToString() == "254")
                {
                    aog_autosteer_data = message[0].ToString() + "," + message[1].ToString() + "," + message[2].ToString() + "," + message[3].ToString() + "," + message[4].ToString() + "," + message[5].ToString() + "," + message[6].ToString() + "," + message[7].ToString();
                    double steerAngleSetPoint = 0;


                    if (message[6] > 100)
                    {
                        steerAngleSetPoint = ((float)((message[6]) << 8 | message[7])) * 0.01 - 655; //high low bytes
                    }
                    else
                    {
                        steerAngleSetPoint = ((float)(message[6] << 8 | message[7])) * 0.01; //high low bytes
                    }

                    if ((message[4] == 125) && (message[5] == 20))
                    {
                        //autosteer is off
                        pb_autosteer_state.BackColor = Color.Red;
                        tb_steering.Value = tb_steering.Maximum / 2;//set it to nutral
                        lbl_desired_angle.Visible = false;
                    }
                    else
                    {
                        //autosteer on
                        pb_autosteer_state.BackColor = Color.Green;
                        lbl_desired_angle.Visible = true;
                        lbl_desired_angle.Text = Math.Round(steerAngleSetPoint,2).ToString();
                        double maxtractorsteerangle = Properties.Settings.Default.max_steer_angle;
                        double steerAngleSetPointtmp = steerAngleSetPoint + maxtractorsteerangle;

                        //TODO need to actually use the deadband setting that is set in the settings page
                        int steerangle = 0;
                        //adjust for deadband


                        if (steerAngleSetPoint == 0)
                        {
                            steerangle = tb_steering.Maximum / 2;
                        }
                        else if (steerAngleSetPoint > 0)
                        { //turn right
                            int tmprange = 32767 - Properties.Settings.Default.joystick_deadband;
                            steerangle = Convert.ToInt32(((steerAngleSetPoint * tmprange) / maxtractorsteerangle) + 18550);
                        }
                        else if (steerAngleSetPoint < 0)
                        { //turn left
                            steerAngleSetPoint = steerAngleSetPoint * -1;
                            int tmprange = 32767 - Properties.Settings.Default.joystick_deadband;
                            steerangle = Convert.ToInt32(((steerAngleSetPoint * tmprange) / maxtractorsteerangle) + 18550);
                            steerangle = (tb_steering.Maximum) - steerangle;
                        }
                        tb_steering.Value = steerangle;//set the slider to the desired steer angle
                    }

                }



                if (message[1].ToString() == "250")
                {
                    aog_machine_data = message[0].ToString() + "," + message[1].ToString() + "," + message[2].ToString() + "," + message[3].ToString() + "," + message[4].ToString() + "," + message[5].ToString() + "," + message[6].ToString() + "," + message[7].ToString();
                    string command = ToBinary(message[5]);
                    if (command.Substring(0, 1) == "1")
                    {
                        infield = true;
                    }
                    else
                    {
                        infield = false;
                    }

                    if (command.Substring(2, 1) == "1")
                    {
                        b6 = true;
                    }
                    else
                    {
                        b6 = false;
                    }
                    if (command.Substring(3, 1) == "1")
                    {
                        b5 = true;
                    }
                    else
                    {
                        b5 = false;
                    }
                    if (command.Substring(4, 1) == "1")
                    {
                        b4 = true;
                    }
                    else
                    {
                        b4 = false;
                    }
                    if (command.Substring(5, 1) == "1")
                    {
                        b3 = true;
                    }
                    else
                    {
                        b3 = false;
                    }

                    if (command.Substring(6, 1) == "1")
                    {
                        b2 = true;
                    }
                    else
                    {
                        b2 = false;
                    }

                    if (command.Substring(7, 1) == "1")
                    {
                        b1 = true;
                    }
                    else
                    {
                        b1 = false;
                    }

                }
            }
           
        }
        public static string ToBinary(int myValue)
        {
            string binVal = Convert.ToString(myValue, 2);
            int bits = 0;
            int bitblock = 8;

            for (int i = 0; i < binVal.Length; i = i + bitblock)
            { bits += bitblock; }

            return binVal.PadLeft(bits, '0');
        }

        private void Form_main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.vehicle_to_control = cb_vehicle_to_control.Text;//save the vehicle for next time
            Properties.Settings.Default.Save();

            client.Close();
            clientaog.Close();
        }

        private void tb_steering_ValueChanged(object sender, EventArgs e)
        {
            lbl_steering_val.Text = tb_steering.Value.ToString();//update the label to help identify deadzone
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            getvehicles();
        }

        private void cb_vehicle_to_control_SelectedIndexChanged(object sender, EventArgs e)
        {
            enable_autosteer();
        }

        private void mapControlsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_control_mapping form = new form_control_mapping(this);
            form.Show(); // Shows page
        }

        private void timer_aog_enable_autosteer_Tick(object sender, EventArgs e)
        {
            enable_autosteer();
        }

        private void timer_joystick_output_Tick(object sender, EventArgs e)
        {
            getGameInfo();//get location/speed from the game
            updatebuttonstate();//just sets the boxes next to the labels as red or green
            //control the virtual joystick

            res = joystick.SetAxis(tb_steering.Maximum - tb_steering.Value, id, HID_USAGES.HID_USAGE_X);
            //res = joystick.SetAxis(tb_speed.Maximum - tb_speed.Value, id, HID_USAGES.HID_USAGE_Y);//if you want to control speed, this could also be used
            //res = joystick.SetAxis(tb_speed.Maximum - tb_speed.Value, id, HID_USAGES.HID_USAGE_Z);
            //set button state
            res = joystick.SetBtn(b1, id, 1);
            res = joystick.SetBtn(b2, id, 2);
            res = joystick.SetBtn(b3, id, 3);
            res = joystick.SetBtn(b4, id, 4);
            res = joystick.SetBtn(b5, id, 5);
            res = joystick.SetBtn(b6, id, 6);
            res = joystick.SetBtn(b7, id, 7);
            res = joystick.SetBtn(b8, id, 8);
        }

        public void updatebuttonstate()
        {
            if (infield)
            {
                pb_field.BackColor = Color.Red;
            }
            else
            {
                pb_field.BackColor = Color.Green;
            }
            if (b1)
            {
                pb_b1.BackColor = Color.Green;
            }
            else
            {
                pb_b1.BackColor = Color.Red;
            }
            if (b2)
            {
                pb_b2.BackColor = Color.Green;
            }
            else
            {
                pb_b2.BackColor = Color.Red;
            }
            if (b3)
            {
                pb_b3.BackColor = Color.Green;
            }
            else
            {
                pb_b3.BackColor = Color.Red;
            }
            if (b4)
            {
                pb_b4.BackColor = Color.Green;
            }
            else
            {
                pb_b4.BackColor = Color.Red;
            }
            if (b5)
            {
                pb_b5.BackColor = Color.Green;
            }
            else
            {
                pb_b5.BackColor = Color.Red;
            }
            if (b6)
            {
                pb_b6.BackColor = Color.Green;
            }
            else
            {
                pb_b6.BackColor = Color.Red;
            }
        }

        public void init_vjoy()
        {
            try
            {
                joystick = new vJoy();
                if (!joystick.vJoyEnabled())
                {
                    MessageBox.Show("vJoy driver not enabled: Failed Getting vJoy attributes.");
                    return;
                }

                VjdStat status = joystick.GetVJDStatus(id);

                // Test if DLL matches the driver
                UInt32 DllVer = 0, DrvVer = 0;
                bool match = joystick.DriverMatch(ref DllVer, ref DrvVer);
                //if (match)
                    //MessageBox.Show("Version of Driver Matches DLL Version ("+ DllVer.ToString()+")");
                //else
                    //MessageBox.Show("Version of Driver (" + DrvVer.ToString() + ") does NOT match DLL Version (" + DllVer.ToString() + ")");
                joystick.AcquireVJD(id);
            }
            catch
            {
                MessageBox.Show("vjoy failed to init");
            }
           
        }
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settings settingspage = new settings();
            settingspage.ShowDialog(); // Shows settings page
        }

        private void dataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            data datapage = new data(this);
            datapage.Show(); // Shows data page
        }

        private void sendtoaog()
        {
            if (cb_vehicle_to_control.Text != "")
            {
                Byte[] sendBytes = Encoding.ASCII.GetBytes("~,"+calculated_lat+","+calculated_lon + "," +calculated_bearing + "," +game_speed);
                UdpClient client = new UdpClient(Properties.Settings.Default.aog_server_ip, Properties.Settings.Default.aog_server_port);
                client.Send(sendBytes, sendBytes.Length);
            }
            
        }

        private void enable_autosteer()
        {
            UdpClient client = new UdpClient(Properties.Settings.Default.aog_server_ip, Properties.Settings.Default.aog_server_port);
            //steer angle and auto steer status
            autoSteerSettings[ssHeaderHi] = 127;// PGN - 32764 as header
            autoSteerSettings[ssHeaderLo] = 253;
            autoSteerSettings[data1] = 5;//steer angle int
            autoSteerSettings[data2] = 7;//steer angle
            autoSteerSettings[data3] = 0;//imu
            autoSteerSettings[data4] = 0;//imu
            autoSteerSettings[data5] = 0;//roll
            autoSteerSettings[data6] = 0;//roll
            autoSteerSettings[data7] = 0;//steering switch status byte 0 or 1
            autoSteerSettings[data8] = 0;//pwm
            client.Send(autoSteerSettings, pgnSentenceLength);
            client.Close();
        }
      
        private void getvehicles()
        {
            try
            {
                gamedata = File.ReadAllText(Properties.Settings.Default.game_file_location);
            }
            catch
            {

            }
           
            cb_vehicle_to_control.Items.Clear();
            string[] vehicles = gamedata.Split('|');
            string[] values = vehicles[0].Split(',');
            foreach (string vehicle in values)
            {
                cb_vehicle_to_control.Items.Add(vehicle);
            }

        }
        private void getGameInfo()//I read the text file that the game outputs and then pull the needed data that you are looking for
        {
            try
            {
                if (cb_vehicle_to_control.Text != "")
                {
                    gamedata = File.ReadAllText(Properties.Settings.Default.game_file_location);

                    string[] vehicles = gamedata.Split('|');
                    bool vehiclefound = false;
                    for (int i = 1; i < vehicles.Length; i++)
                    {
                        if (vehicles[i] != "")
                        {
                            string[] values = vehicles[i].Split(',');
                            string vehiclename = values[5];
                            if (vehiclename == cb_vehicle_to_control.Text)
                            {
                                gamedataspecific = vehicles[i];//just for that data page
                                vehiclefound = true;
                                double mapMiddle = 2048 / 2;

                                //lat calc
                                double latdec = Convert.ToDouble(values[2])*-1;
                                game_lat = values[2];//just used in the data page
                                latdec += mapMiddle;
                                latdec = latdec *.0005404;//wish i could say there was a formula behind this but it was guess and check until game distance = aog distance
                         
                                calculated_lat = latdec.ToString();

                                //lon calc
                                double longdec = Convert.ToDouble(values[0]);
                                game_lon = values[0];
                                longdec += mapMiddle;
                                longdec = longdec * .00071330;//wish i could say there was a formula behind this but it was guess and check until game distance = aog distance
                           

                                calculated_lon = longdec.ToString();


                                game_elev = Math.Round(Convert.ToDouble(values[1]), 0).ToString();//its data, but not used for anything at this moment
                
                                //compass
                                game_compass = values[3];//used on the data tab

                                double compass = Convert.ToDouble(values[3]);

                                string tmpgame_compass = Math.Round(compass, 1).ToString();
                                if (tmpgame_compass.Contains("."))
                                {
                                    string[] tmp = tmpgame_compass.Split('.');
                                    while (tmp[0].Length < 3)
                                    {
                                        tmp[0] = "0" + tmp[0];
                                    }
                                    if (tmp[1].Length < 1)
                                    {
                                        tmp[1] = "0";
                                    }
                                    calculated_bearing = tmp[0] + "." + tmp[1];
                                }
                                else
                                {
                                    while (tmpgame_compass.Length < 3)
                                    {
                                        tmpgame_compass = "0" + tmpgame_compass;
                                    }
                                    calculated_bearing = tmpgame_compass + ".0";
                                }


                                //speed
                                game_speed = Math.Round(Convert.ToDouble(values[4]), 2).ToString();
                            }
                        }
                       
                    }

                    if (!vehiclefound)
                    {//if that vehicle isnt found then clear it out
                        cb_vehicle_to_control.Text = "";
                        getvehicles();
                    }

                  


                   
                }
                else
                {
                    if (cb_vehicle_to_control.Items.Count==0)
                    {
                        getvehicles();
                    }
                    
                }
               
             

            }
            catch
            {

            }

        }
    }
}
