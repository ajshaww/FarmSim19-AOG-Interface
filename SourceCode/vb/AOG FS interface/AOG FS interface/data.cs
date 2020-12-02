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
    public partial class data : Form
    {
        Form_main f1;
        public data(Form_main _f1)
        {
            InitializeComponent();
            this.f1 = _f1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txt_farmsim_output.Text = f1.gamedataspecific;
            txt_game_x.Text = f1.game_lon;
            txt_game_y.Text = f1.game_lat;
            txt_game_z.Text = f1.game_elev;
            txt_game_bearing.Text = f1.game_compass;
            txt_game_speed.Text = f1.game_speed;
            txt_calculated_bearing.Text = f1.calculated_bearing;
            txt_calculated_lat.Text = f1.calculated_lat;
            txt_calculated_lon.Text = f1.calculated_lon;
        }

        private void data_Load(object sender, EventArgs e)
        {

        }
    }
}
