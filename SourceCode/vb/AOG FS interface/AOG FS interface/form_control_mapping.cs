using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AOG_FS_interface
{
    public partial class form_control_mapping : Form
    {
        Form_main f1;
        int allowedtime = 10;//this is where the timer is going to start
        int timeleft = 10;
        string action = "";

        public form_control_mapping(Form_main _f1)
        {
            InitializeComponent();
            this.f1 = _f1;
        }

     

       
        private void btn_left_Click(object sender, EventArgs e)
        {
            timeleft = allowedtime;
            action = "Turn Left";
            lbl_action.Visible = true;
            timer1.Start();
            f1.pause_udp = true;
        }
        private void btn_right_Click(object sender, EventArgs e)
        {
            timeleft = allowedtime;
            action = "Turn Right";
            lbl_action.Visible = true;
            timer1.Start();
            f1.pause_udp = true;
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            timeleft = allowedtime;
            action = "Button1";
            lbl_action.Visible = true;
            timer1.Start();
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            timeleft = allowedtime;
            action = "Button2";
            lbl_action.Visible = true;
            timer1.Start();
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            timeleft = allowedtime;
            action = "Button3";
            lbl_action.Visible = true;
            timer1.Start();
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            timeleft = allowedtime;
            action = "Button4";
            lbl_action.Visible = true;
            timer1.Start();
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            timeleft = allowedtime;
            action = "Button5";
            lbl_action.Visible = true;
            timer1.Start();
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            timeleft = allowedtime;
            action = "Button6";
            lbl_action.Visible = true;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeleft > 0)
            {
                timeleft -= 1;
                lbl_action.Text = "Emulating " + action + " in " + timeleft.ToString() + "s";
            }
            else
            {
                timer1.Stop();

                switch (action)
                {
                    case "Turn Left":
                        f1.tb_steering.Value = f1.tb_steering.Minimum;
                        break;
                    case "Turn Right":
                        f1.tb_steering.Value = f1.tb_steering.Maximum;
                        break;
                    case "Button1":
                        f1.b1 = true;
                        break;
                    case "Button2":
                        f1.b2 = true;
                        break;
                    case "Button3":
                        f1.b3 = true;
                        break;
                    case "Button4":
                        f1.b4 = true;
                        break;
                    case "Button5":
                        f1.b5 = true;
                        break;
                    case "Button6":
                        f1.b6 = true;
                        break;
                }

                timer2.Start();//this timer negates what we just did above;
                lbl_action.Visible = false;
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            switch (action)
            {
                case "Turn Left":
                    f1.tb_steering.Value = f1.tb_steering.Maximum/2;
                    break;
                case "Turn Right":
                    f1.tb_steering.Value = f1.tb_steering.Maximum / 2;
                    break;
                case "Button1":
                    f1.b1 = false;
                    break;
                case "Button2":
                    f1.b2 = false;
                    break;
                case "Button3":
                    f1.b3 = false;
                    break;
                case "Button4":
                    f1.b4 = false;
                    break;
                case "Button5":
                    f1.b5 = false;
                    break;
                case "Button6":
                    f1.b6 = false;
                    break;
            }
            action = "";
        }

        private void form_control_mapping_Load(object sender, EventArgs e)
        {
            f1.pause_udp = true;
            f1.tb_steering.Value = f1.tb_steering.Maximum / 2;
            f1.b1 = false;
            f1.b2 = false;
            f1.b3 = false;
            f1.b4 = false;
            f1.b5 = false;
            f1.b6 = false;
        }

        private void form_control_mapping_FormClosing(object sender, FormClosingEventArgs e)
        {
            f1.pause_udp = false;
        }
    }
}
