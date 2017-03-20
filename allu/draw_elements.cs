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
    /// <summary>
    /// drawing methods
    /// </summary>
    public class DrawElements : Game
    //the class contains drawing elements
    {

        public Graphics graph; //the reference to the board graphics

        //storing global class locally
        public GlobalParameters glb_settings;

        //default constructor
        public DrawElements()
        {

        }

        //overwritten class constructor
        public DrawElements(System.Drawing.Graphics f) : this() // constructor chain
        {
            graph = f; //copy class reference to the class header
        }


        public override void DrawGrid()
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

        public override void DrawBorderInitial()
        {
            //set color
            var c = Color.Red;
            var pen = new System.Drawing.Pen(c);

            graph.DrawLine(pen, glb_settings.get_map_dim_parameter_x() / 2 * glb_settings.get_map_box_size(), 0, glb_settings.get_map_dim_parameter_x() / 2 * glb_settings.get_map_box_size(), glb_settings.get_map_dim_parameter_y() * glb_settings.get_map_box_size());
        }

        public override void DrawMap(int[,] terra)
        {

            //iterate through the map
            for (int i = 0; i < terra.GetLength(0); i++)
            {
                for (int j = 0; j < terra.GetLength(1); j++)
                {
                    DrawBoxXY(terra, i, j);

                }
            }
        }

        private void DrawBoxXY(int[,] terra, int i, int j)
        {
            Brush c;

            switch (terra[i, j])
            {
                case (int)TerrainKind.grass:
                    c = Brushes.DarkGreen;
                    break;
                case (int)TerrainKind.road:
                    c = Brushes.DarkSlateGray;
                    break;
                case (int)TerrainKind.city:
                    c = Brushes.DarkOliveGreen;
                    break;
                case (int)TerrainKind.water:
                    c = Brushes.Navy;
                    break;
                default:
                    c = Brushes.DarkGreen;
                    break;
            }

            //draw actual box
            graph.FillRectangle(c, i * glb_settings.get_map_box_size() + 1, j * glb_settings.get_map_box_size() + 1, glb_settings.get_map_box_size() - 1, glb_settings.get_map_box_size() - 1);
        }

        public override void DrawArmyXY(PosXY pos, Terrain terra)
        {
            //set color
            var c = Color.White;
            if (terra.FriendFoe[pos.PosX, pos.PosY] != (int)FriendFoeKind.friend)
                c = Color.Orange;

            var pen = new System.Drawing.Pen(c);

            var x = pos.PosX * glb_settings.get_map_box_size();
            var y = pos.PosY * glb_settings.get_map_box_size();

            var army_type = terra.ArmyUnits[pos];

            switch ((int)army_type.ArmyType)
            {
                case (int)ArmyType.light_infantry:
                    //infantry light
                    DrawInfantry(pen, x, y);
                    break;
                case (int)ArmyType.heavy_infantry:
                    //infantry heavy
                    DrawInfantry(pen, x, y);
                    break;
                default:
                    break;
            }

            //heavy bars added
            if ((int)army_type.ArmyType == (int)ArmyType.heavy_infantry || (int)army_type.ArmyType == (int)ArmyType.heavy_cavalry || (int)army_type.ArmyType == (int)ArmyType.heavy_artillery)
            {
                graph.DrawLine(pen, x + 2, y + 2, x + 10, y + 2);
            }
        }

        private void DrawInfantry(Pen pen, int x, int y)
        {
            graph.DrawLine(pen, x + 2, y + 4, x + 10, y + 4);
            graph.DrawLine(pen, x + 2, y + 14, x + 10, y + 14);
            graph.DrawLine(pen, x + 6, y + 4, x + 6, y + 14);
        }

        public override void DrawArmy(Terrain Terra)
        {
            var pos = new PosXY();
            foreach (var item in Terra.ArmyUnits)
            {
                pos = item.Key;
                DrawArmyXY(pos, Terra);
            }
        }

    }
}
