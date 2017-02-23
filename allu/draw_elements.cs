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
            //set color
            var c = Color.Black;
            var pen = new System.Drawing.Pen(c);
            //draw actual grid
            for (int i = 0; i <= glb_settings.get_map_dim_parameter_x(); i++)
            {
                graph.DrawLine(pen, i * glb_settings.get_map_box_size(), 0, i * glb_settings.get_map_box_size(), glb_settings.get_map_dim_parameter_y() * glb_settings.get_map_box_size());
            }
            for (int j = 0; j <= glb_settings.get_map_dim_parameter_y(); j++)
            {
                graph.DrawLine(pen, 0, j * glb_settings.get_map_box_size(), glb_settings.get_map_dim_parameter_x() * glb_settings.get_map_box_size(), j * glb_settings.get_map_box_size());
            }
        }

        public override void Draw_Border_Initial()
        {
            //set color
            var c = Color.Red;
            var pen = new System.Drawing.Pen(c);

            //draw actual line
            //graph.DrawLine(pen, 0, 0, 100, 100);
            graph.DrawLine(pen, glb_settings.get_map_dim_parameter_x() / 2 * glb_settings.get_map_box_size(), 0, glb_settings.get_map_dim_parameter_x() / 2 * glb_settings.get_map_box_size(), glb_settings.get_map_dim_parameter_y() * glb_settings.get_map_box_size());
        }

        public override void Draw_Map(int[,] terra)
        {
          
            //iterate through the map
            for (int i = 0; i < terra.GetLength(0); i++)
            {
                for (int j = 0; j < terra.GetLength(1); j++)
                {
                    //set color
                    if (terra[i, j] == (int)Terrain_Type.grass)
                    {
                        var c = Brushes.DarkGreen;
                    }
                    //draw actual box
                    graph.FillRectangle(c, i * glb_settings.get_map_box_size() + 1, j * glb_settings.get_map_box_size() + 1, glb_settings.get_map_box_size() - 1, glb_settings.get_map_box_size() - 1);
                }
            }
        }
    }
}
