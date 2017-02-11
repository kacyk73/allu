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
        glb_params glb_settings = new glb_params();
        public main()
        {
            InitializeComponent();

            //initialise global settings object
            glb_settings.set_map_dim_parameters(50, 40); //to be fixed
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            board frm = new board();

            //set dynamic board size
            frm.SetDesktopBounds(0, 0, glb_settings.get_map_dim_parameter_x() * glb_settings.get_map_box_size(), glb_settings.get_map_dim_parameter_y() * glb_settings.get_map_box_size());

            frm.ShowDialog();

    
        }
    }
}
