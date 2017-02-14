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
    public class draw_elements : game
        //the class contains drawing elements
    {

        public Graphics graph; //the reference to the board graphics

        //storing global class locally
        public glb_params glb_settings;

        //overwritten class constructor
        public draw_elements(System.Drawing.Graphics f)
        {
            graph = f; //copy class reference to the class header
        }


        public override void Draw_Grid()
        {
            
            var c = Color.Black;
            var pen = new System.Drawing.Pen(c);
            graph.DrawLine(pen, 0, 0, glb_settings.get_map_dim_parameter_x() * glb_settings.get_map_box_size(), glb_settings.get_map_dim_parameter_y() * glb_settings.get_map_box_size());
            
        }
    }
}
