namespace AOG_FS_interface
{
    partial class Form_main
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
            this.tb_steering = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pb_b2 = new System.Windows.Forms.PictureBox();
            this.pb_b3 = new System.Windows.Forms.PictureBox();
            this.pb_b4 = new System.Windows.Forms.PictureBox();
            this.pb_b5 = new System.Windows.Forms.PictureBox();
            this.pb_b6 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pb_field = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lbl_steering_val = new System.Windows.Forms.Label();
            this.pb_b1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_desired_angle = new System.Windows.Forms.Label();
            this.pb_autosteer_state = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mapControlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer_joystick_output = new System.Windows.Forms.Timer(this.components);
            this.timer_to_aog = new System.Windows.Forms.Timer(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.cb_vehicle_to_control = new System.Windows.Forms.ComboBox();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.timer_aog_enable_autosteer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tb_steering)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_b2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_b3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_b4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_b5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_b6)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_field)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_b1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_autosteer_state)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_steering
            // 
            this.tb_steering.Location = new System.Drawing.Point(83, 27);
            this.tb_steering.Name = "tb_steering";
            this.tb_steering.Size = new System.Drawing.Size(237, 45);
            this.tb_steering.TabIndex = 0;
            this.tb_steering.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tb_steering.ValueChanged += new System.EventHandler(this.tb_steering_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Steering:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Button 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Button 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Button 3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Button 4";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Button 5";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Button 6";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Red;
            this.pictureBox1.Location = new System.Drawing.Point(85, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(15, 15);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pb_b2
            // 
            this.pb_b2.BackColor = System.Drawing.Color.Red;
            this.pb_b2.Location = new System.Drawing.Point(85, 74);
            this.pb_b2.Name = "pb_b2";
            this.pb_b2.Size = new System.Drawing.Size(15, 15);
            this.pb_b2.TabIndex = 13;
            this.pb_b2.TabStop = false;
            // 
            // pb_b3
            // 
            this.pb_b3.BackColor = System.Drawing.Color.Red;
            this.pb_b3.Location = new System.Drawing.Point(85, 94);
            this.pb_b3.Name = "pb_b3";
            this.pb_b3.Size = new System.Drawing.Size(15, 15);
            this.pb_b3.TabIndex = 14;
            this.pb_b3.TabStop = false;
            // 
            // pb_b4
            // 
            this.pb_b4.BackColor = System.Drawing.Color.Red;
            this.pb_b4.Location = new System.Drawing.Point(85, 114);
            this.pb_b4.Name = "pb_b4";
            this.pb_b4.Size = new System.Drawing.Size(15, 15);
            this.pb_b4.TabIndex = 15;
            this.pb_b4.TabStop = false;
            // 
            // pb_b5
            // 
            this.pb_b5.BackColor = System.Drawing.Color.Red;
            this.pb_b5.Location = new System.Drawing.Point(85, 134);
            this.pb_b5.Name = "pb_b5";
            this.pb_b5.Size = new System.Drawing.Size(15, 15);
            this.pb_b5.TabIndex = 16;
            this.pb_b5.TabStop = false;
            // 
            // pb_b6
            // 
            this.pb_b6.BackColor = System.Drawing.Color.Red;
            this.pb_b6.Location = new System.Drawing.Point(85, 154);
            this.pb_b6.Name = "pb_b6";
            this.pb_b6.Size = new System.Drawing.Size(15, 15);
            this.pb_b6.TabIndex = 17;
            this.pb_b6.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(64, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(241, 31);
            this.label11.TabIndex = 20;
            this.label11.Text = "Farm Sim Control";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pb_field);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.lbl_steering_val);
            this.groupBox1.Controls.Add(this.pb_b1);
            this.groupBox1.Controls.Add(this.tb_steering);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pb_b6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.pb_b5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.pb_b4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.pb_b3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.pb_b2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(15, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 202);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Farm Sim Emulated Control status:";
            // 
            // pb_field
            // 
            this.pb_field.BackColor = System.Drawing.Color.Red;
            this.pb_field.Location = new System.Drawing.Point(237, 56);
            this.pb_field.Name = "pb_field";
            this.pb_field.Size = new System.Drawing.Size(15, 15);
            this.pb_field.TabIndex = 25;
            this.pb_field.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(170, 54);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 20);
            this.label13.TabIndex = 24;
            this.label13.Text = "In Field";
            // 
            // lbl_steering_val
            // 
            this.lbl_steering_val.AutoSize = true;
            this.lbl_steering_val.Location = new System.Drawing.Point(277, 16);
            this.lbl_steering_val.Name = "lbl_steering_val";
            this.lbl_steering_val.Size = new System.Drawing.Size(13, 13);
            this.lbl_steering_val.TabIndex = 21;
            this.lbl_steering_val.Text = "0";
            // 
            // pb_b1
            // 
            this.pb_b1.BackColor = System.Drawing.Color.Red;
            this.pb_b1.Location = new System.Drawing.Point(85, 54);
            this.pb_b1.Name = "pb_b1";
            this.pb_b1.Size = new System.Drawing.Size(15, 15);
            this.pb_b1.TabIndex = 20;
            this.pb_b1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_desired_angle);
            this.groupBox2.Controls.Add(this.pb_autosteer_state);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(15, 341);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(326, 59);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ag Open GPS data:";
            // 
            // lbl_desired_angle
            // 
            this.lbl_desired_angle.AutoSize = true;
            this.lbl_desired_angle.Location = new System.Drawing.Point(218, 30);
            this.lbl_desired_angle.Name = "lbl_desired_angle";
            this.lbl_desired_angle.Size = new System.Drawing.Size(13, 13);
            this.lbl_desired_angle.TabIndex = 21;
            this.lbl_desired_angle.Text = "0";
            this.lbl_desired_angle.Visible = false;
            // 
            // pb_autosteer_state
            // 
            this.pb_autosteer_state.BackColor = System.Drawing.Color.Red;
            this.pb_autosteer_state.Location = new System.Drawing.Point(149, 28);
            this.pb_autosteer_state.Name = "pb_autosteer_state";
            this.pb_autosteer_state.Size = new System.Drawing.Size(15, 15);
            this.pb_autosteer_state.TabIndex = 20;
            this.pb_autosteer_state.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(137, 20);
            this.label12.TabIndex = 20;
            this.label12.Text = "AutoSteer Status:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(358, 24);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.dataToolStripMenuItem,
            this.mapControlsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.dataToolStripMenuItem.Text = "Data";
            this.dataToolStripMenuItem.Click += new System.EventHandler(this.dataToolStripMenuItem_Click);
            // 
            // mapControlsToolStripMenuItem
            // 
            this.mapControlsToolStripMenuItem.Name = "mapControlsToolStripMenuItem";
            this.mapControlsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.mapControlsToolStripMenuItem.Text = "Map Controls";
            this.mapControlsToolStripMenuItem.Click += new System.EventHandler(this.mapControlsToolStripMenuItem_Click);
            // 
            // timer_joystick_output
            // 
            this.timer_joystick_output.Enabled = true;
            this.timer_joystick_output.Interval = 50;
            this.timer_joystick_output.Tick += new System.EventHandler(this.timer_joystick_output_Tick);
            // 
            // timer_to_aog
            // 
            this.timer_to_aog.Enabled = true;
            this.timer_to_aog.Tick += new System.EventHandler(this.timer_to_aog_Tick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Vehicle to control:";
            // 
            // cb_vehicle_to_control
            // 
            this.cb_vehicle_to_control.FormattingEnabled = true;
            this.cb_vehicle_to_control.Location = new System.Drawing.Point(15, 92);
            this.cb_vehicle_to_control.Name = "cb_vehicle_to_control";
            this.cb_vehicle_to_control.Size = new System.Drawing.Size(238, 21);
            this.cb_vehicle_to_control.TabIndex = 25;
            this.cb_vehicle_to_control.SelectedIndexChanged += new System.EventHandler(this.cb_vehicle_to_control_SelectedIndexChanged);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(259, 92);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_refresh.TabIndex = 27;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // timer_aog_enable_autosteer
            // 
            this.timer_aog_enable_autosteer.Enabled = true;
            this.timer_aog_enable_autosteer.Interval = 5000;
            this.timer_aog_enable_autosteer.Tick += new System.EventHandler(this.timer_aog_enable_autosteer_Tick);
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 422);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cb_vehicle_to_control);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_main";
            this.Text = "Farm Sim Control";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_main_FormClosing);
            this.Load += new System.EventHandler(this.Form_main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tb_steering)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_b2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_b3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_b4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_b5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_b6)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_field)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_b1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_autosteer_state)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pb_b2;
        private System.Windows.Forms.PictureBox pb_b3;
        private System.Windows.Forms.PictureBox pb_b4;
        private System.Windows.Forms.PictureBox pb_b5;
        private System.Windows.Forms.PictureBox pb_b6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pb_autosteer_state;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.PictureBox pb_b1;
        private System.Windows.Forms.Label lbl_steering_val;
        private System.Windows.Forms.Timer timer_joystick_output;
        private System.Windows.Forms.Timer timer_to_aog;
        private System.Windows.Forms.Label lbl_desired_angle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cb_vehicle_to_control;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.PictureBox pb_field;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ToolStripMenuItem mapControlsToolStripMenuItem;
        public System.Windows.Forms.TrackBar tb_steering;
        private System.Windows.Forms.Timer timer_aog_enable_autosteer;
    }
}

