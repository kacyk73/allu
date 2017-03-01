using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace allu
{
    /// <summary>
    /// the game welcome menu form
    /// </summary>
    public partial class Main : Form
    {
        //initialise global settings object
        public GlobalParameters glb_settings;


        public Main()
        {
            
            InitializeComponent();

            glb_settings = new GlobalParameters();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            //initialise global settings object
            glb_settings.set_map_dim_parameters(Convert.ToInt32(txt_global_x.Text), Convert.ToInt32(txt_global_y.Text));

            Board frm = new Board();
            //pass global variables class to the 2nd form
            frm.glb_settings = glb_settings;

            //temp board dimentions in pxls
            int x = glb_settings.get_map_dim_parameter_x() * glb_settings.get_map_box_size() + glb_settings.get_map_menu_offset() + glb_settings.get_map_box_size();
            int y = glb_settings.get_map_dim_parameter_y() * glb_settings.get_map_box_size() + 2 * glb_settings.get_map_box_size();


            //set dynamic board size
            frm.SetDesktopBounds(0, 0, x, y);

            frm.ShowDialog();

            
        }

        private void txt_global_x_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txt_global_x.Text) % 2 != 0)
            {
                txt_global_x.Text = Convert.ToString(Convert.ToInt32(txt_global_x.Text) + 1);
            }
        }
    }
}
