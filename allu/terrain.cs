﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace allu
{
    /// <summary>
    /// the game map terrain
    /// </summary>
    public class Terrain : Map

    {
        //storing global class locally
        public GlobalParameters glb_settings;

        public override void FriendFoeInitialisation()
        {
            int[,] friend_foe = new int[glb_settings.get_map_dim_parameter_x(), glb_settings.get_map_dim_parameter_y()];

            for (int i = 0; i < glb_settings.get_map_dim_parameter_x(); i++)
                for (int j = 0; j < glb_settings.get_map_dim_parameter_y(); j++)
                {
                    if (i < glb_settings.get_map_dim_parameter_x() / 2)
                        friend_foe[i, j] = (int)FriendFoeKinds.friend;
                    else
                        friend_foe[i, j] = (int)FriendFoeKinds.foe;
                }
            FriendFoe = friend_foe;

        }

        //generating the population
        public override void GeneratePopulation()
        {
            Random rnd = new Random();
            int [,] pop = new int[glb_settings.get_map_dim_parameter_x(), glb_settings.get_map_dim_parameter_y()];
            int[,] terra = new int[glb_settings.get_map_dim_parameter_x(), glb_settings.get_map_dim_parameter_y()];

            terra = MapTerrain;
            for (int i = 0; i < glb_settings.get_map_dim_parameter_x(); i++)
                for (int j = 0; j < glb_settings.get_map_dim_parameter_y(); j++)
                {
                    switch (terra[i, j])
                    {
                        case (int)TerrainKinds.grass:
                            pop[i, j] = rnd.Next((int)PopulationSettings.minimal, (int)PopulationSettings.maximal);
                            break;
                        case (int)TerrainKinds.city:
                            pop[i, j] = (int)PopulationSettings.city_factor * rnd.Next((int)PopulationSettings.minimal, (int)PopulationSettings.maximal);
                            break;
                        case (int)TerrainKinds.water:
                            pop[i, j] = 0;
                            break;
                        case (int)TerrainKinds.road:
                            pop[i, j] = 0;
                            break;
                        default:
                            break;
                    }
                }
            Population = pop;
        }

        public override string GetLabelsFriendFoe(int i)
        {
            string label = "";

            switch (i)
            {
                case (int)FriendFoeKinds.friend:
                    label = "friend";
                    break;
                case (int)FriendFoeKinds.foe:
                    label = "foe";
                    break;
            }

            return label;
        }

        //locate current position on a map grid, return false if out of the map
        public override Map.PosXY GetPositionXY(int x, int y)
        {
            var result = new PosXY();

            if ((x >= 0) && (y >= 0) && (x < glb_settings.get_map_dim_parameter_x() * glb_settings.get_map_box_size())
                && (y < glb_settings.get_map_dim_parameter_y() * glb_settings.get_map_box_size()))
            {
                result.PosX = x / glb_settings.get_map_box_size();
                result.PosY = y / glb_settings.get_map_box_size();
            }

            return result;
        }

        public override void Load_Map()
        {
            //loading the map from the file 
            //the terrain type is stored in the enum
            //Terrain_Type

            string[] lines = System.IO.File.ReadAllLines(@"txt\map.txt");

            int[,] terr = new int[glb_settings.get_map_dim_parameter_x(), glb_settings.get_map_dim_parameter_y()];

            //initiating the terr matrix
            int x, y;
            y = 0;
            foreach (var item in lines)
            {
                x = 0;
                foreach (var s in item)
                {
                    switch (s)
                    {
                        case 'v':
                            terr[x, y] = (int)TerrainKinds.grass;
                            x++;
                            break;
                        case 'w':
                            terr[x, y] = (int)TerrainKinds.water;
                            x++;
                            break;
                        case 'r':
                            terr[x, y] = (int)TerrainKinds.road;
                            x++;
                            break;
                        case 'c':
                            terr[x, y] = (int)TerrainKinds.city;
                            x++;
                            break;
                        default:
                            break;
                    }
                }
                y++;
            }
            MapTerrain = terr;
        }
    }
}
