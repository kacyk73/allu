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
    public partial class main : Form
    {
        //initialise global settings object
        public glb_params glb_settings;

        //public static glb_params glb_settings { get; set; }


        public main()
        {
            
            InitializeComponent();

            glb_settings = new glb_params();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            //initialise global settings object
            glb_settings.set_map_dim_parameters(Convert.ToInt32(txt_global_x.Text), Convert.ToInt32(txt_global_y.Text));

            board frm = new board();
            frm.glb_settings = glb_settings;

            //temp board dimentions in pxls
            int x = glb_settings.get_map_dim_parameter_x() * glb_settings.get_map_box_size() + glb_settings.get_map_menu_offset() + glb_settings.get_map_box_size();
            int y = glb_settings.get_map_dim_parameter_y() * glb_settings.get_map_box_size() + glb_settings.get_map_box_size();


            //set dynamic board size
            frm.SetDesktopBounds(0, 0, x, y);

            frm.ShowDialog();

            
        }
    }
}
