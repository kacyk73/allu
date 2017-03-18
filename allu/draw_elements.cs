﻿using System;
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

        public override void DrawArmyXY(PosXY pos)
        {
            //set color
            var c = Color.Red;
            var pen = new System.Drawing.Pen(c);

            graph.DrawLine(pen, pos.PosX * glb_settings.get_map_box_size()+3, pos.PosY * glb_settings.get_map_box_size() + 3, pos.PosX * glb_settings.get_map_box_size() + 13, pos.PosY * glb_settings.get_map_box_size() + 13);
        }
    }
}
