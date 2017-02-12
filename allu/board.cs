using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace allu
{
    public partial class board : Form 
    {

        public glb_params glb_settings;

        public board()
        {

            InitializeComponent();

            btn_start2.SetBounds(20 + 20, 200, 60, 30);
        }

        private void btn_start2_Click(object sender, EventArgs e)
        {
            var x = CreateGraphics();
            var c = Color.Black;
            var pen = new System.Drawing.Pen(c);
            x.DrawLine(pen, 0, 0, glb_settings.get_map_dim_parameter_x() * glb_settings.get_map_box_size(), glb_settings.get_map_dim_parameter_y() * glb_settings.get_map_box_size());
            
        }
    }
}
