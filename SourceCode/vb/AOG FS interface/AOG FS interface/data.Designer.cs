namespace AOG_FS_interface
{
    partial class data
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_farmsim_output = new System.Windows.Forms.TextBox();
            this.txt_data_to_aog = new System.Windows.Forms.TextBox();
            this.txt_aog_autosteer_data = new System.Windows.Forms.TextBox();
            this.txt_aog_machine_data = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txt_calculated_lon = new System.Windows.Forms.TextBox();
            this.txt_calculated_lat = new System.Windows.Forms.TextBox();
            this.txt_game_y = new System.Windows.Forms.TextBox();
            this.txt_game_x = new System.Windows.Forms.TextBox();
            this.txt_game_bearing = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_game_speed = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_game_z = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_calculated_bearing = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "From AOG autosteer:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "From AOG Machine Port:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Farm Sim output:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "To AOG:";
            // 
            // txt_farmsim_output
            // 
            this.txt_farmsim_output.Location = new System.Drawing.Point(98, 21);
            this.txt_farmsim_output.Name = "txt_farmsim_output";
            this.txt_farmsim_output.ReadOnly = true;
            this.txt_farmsim_output.Size = new System.Drawing.Size(697, 20);
            this.txt_farmsim_output.TabIndex = 4;
            // 
            // txt_data_to_aog
            // 
            this.txt_data_to_aog.Location = new System.Drawing.Point(122, 107);
            this.txt_data_to_aog.Name = "txt_data_to_aog";
            this.txt_data_to_aog.ReadOnly = true;
            this.txt_data_to_aog.Size = new System.Drawing.Size(673, 20);
            this.txt_data_to_aog.TabIndex = 5;
            // 
            // txt_aog_autosteer_data
            // 
            this.txt_aog_autosteer_data.Location = new System.Drawing.Point(144, 19);
            this.txt_aog_autosteer_data.Name = "txt_aog_autosteer_data";
            this.txt_aog_autosteer_data.ReadOnly = true;
            this.txt_aog_autosteer_data.Size = new System.Drawing.Size(651, 20);
            this.txt_aog_autosteer_data.TabIndex = 6;
            // 
            // txt_aog_machine_data
            // 
            this.txt_aog_machine_data.Location = new System.Drawing.Point(144, 45);
            this.txt_aog_machine_data.Name = "txt_aog_machine_data";
            this.txt_aog_machine_data.ReadOnly = true;
            this.txt_aog_machine_data.Size = new System.Drawing.Size(651, 20);
            this.txt_aog_machine_data.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(328, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 37);
            this.label5.TabIndex = 8;
            this.label5.Text = "Data";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Game X:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Game Y:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Calculated Latitude:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Calculated Longitude:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(44, 128);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Bearing:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txt_calculated_lon
            // 
            this.txt_calculated_lon.Location = new System.Drawing.Point(122, 55);
            this.txt_calculated_lon.Name = "txt_calculated_lon";
            this.txt_calculated_lon.ReadOnly = true;
            this.txt_calculated_lon.Size = new System.Drawing.Size(673, 20);
            this.txt_calculated_lon.TabIndex = 17;
            // 
            // txt_calculated_lat
            // 
            this.txt_calculated_lat.Location = new System.Drawing.Point(122, 29);
            this.txt_calculated_lat.Name = "txt_calculated_lat";
            this.txt_calculated_lat.ReadOnly = true;
            this.txt_calculated_lat.Size = new System.Drawing.Size(673, 20);
            this.txt_calculated_lat.TabIndex = 16;
            // 
            // txt_game_y
            // 
            this.txt_game_y.Location = new System.Drawing.Point(98, 73);
            this.txt_game_y.Name = "txt_game_y";
            this.txt_game_y.ReadOnly = true;
            this.txt_game_y.Size = new System.Drawing.Size(697, 20);
            this.txt_game_y.TabIndex = 15;
            // 
            // txt_game_x
            // 
            this.txt_game_x.Location = new System.Drawing.Point(98, 47);
            this.txt_game_x.Name = "txt_game_x";
            this.txt_game_x.ReadOnly = true;
            this.txt_game_x.Size = new System.Drawing.Size(697, 20);
            this.txt_game_x.TabIndex = 14;
            // 
            // txt_game_bearing
            // 
            this.txt_game_bearing.Location = new System.Drawing.Point(98, 125);
            this.txt_game_bearing.Name = "txt_game_bearing";
            this.txt_game_bearing.ReadOnly = true;
            this.txt_game_bearing.Size = new System.Drawing.Size(697, 20);
            this.txt_game_bearing.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_game_z);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txt_game_speed);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txt_game_y);
            this.groupBox1.Controls.Add(this.txt_game_bearing);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_farmsim_output);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_game_x);
            this.groupBox1.Location = new System.Drawing.Point(12, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(801, 185);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data From Farming Simulator";
            // 
            // txt_game_speed
            // 
            this.txt_game_speed.Location = new System.Drawing.Point(98, 151);
            this.txt_game_speed.Name = "txt_game_speed";
            this.txt_game_speed.ReadOnly = true;
            this.txt_game_speed.Size = new System.Drawing.Size(697, 20);
            this.txt_game_speed.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(44, 154);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Speed:";
            // 
            // txt_game_z
            // 
            this.txt_game_z.Location = new System.Drawing.Point(98, 99);
            this.txt_game_z.Name = "txt_game_z";
            this.txt_game_z.ReadOnly = true;
            this.txt_game_z.Size = new System.Drawing.Size(697, 20);
            this.txt_game_z.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(44, 102);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Game Z:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_aog_autosteer_data);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txt_aog_machine_data);
            this.groupBox2.Location = new System.Drawing.Point(12, 247);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(801, 79);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data From AgOpenGPS";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_calculated_bearing);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txt_data_to_aog);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txt_calculated_lon);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txt_calculated_lat);
            this.groupBox3.Location = new System.Drawing.Point(12, 332);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(801, 137);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Program Data";
            // 
            // txt_calculated_bearing
            // 
            this.txt_calculated_bearing.Location = new System.Drawing.Point(122, 81);
            this.txt_calculated_bearing.Name = "txt_calculated_bearing";
            this.txt_calculated_bearing.ReadOnly = true;
            this.txt_calculated_bearing.Size = new System.Drawing.Size(673, 20);
            this.txt_calculated_bearing.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 84);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "Calculated Bearing:";
            // 
            // data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 491);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Name = "data";
            this.Text = "data";
            this.Load += new System.EventHandler(this.data_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_farmsim_output;
        private System.Windows.Forms.TextBox txt_data_to_aog;
        private System.Windows.Forms.TextBox txt_aog_autosteer_data;
        private System.Windows.Forms.TextBox txt_aog_machine_data;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txt_calculated_lon;
        private System.Windows.Forms.TextBox txt_calculated_lat;
        private System.Windows.Forms.TextBox txt_game_y;
        private System.Windows.Forms.TextBox txt_game_x;
        private System.Windows.Forms.TextBox txt_game_bearing;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_game_z;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_game_speed;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_calculated_bearing;
        private System.Windows.Forms.Label label13;
    }
}