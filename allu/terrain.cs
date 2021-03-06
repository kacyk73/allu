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
        //default constructor
        public Terrain()
        {

        }
        public Terrain(int gamestatus) : this()
        {
            this.GameStatus = gamestatus;
        }

        //storing global class locally
        public GlobalParameters glb_settings;

        public override void FriendFoeInitialisation()
        {
            int[,] friend_foe = new int[glb_settings.get_map_dim_parameter_x(), glb_settings.get_map_dim_parameter_y()];

            for (int i = 0; i < glb_settings.get_map_dim_parameter_x(); i++)
                for (int j = 0; j < glb_settings.get_map_dim_parameter_y(); j++)
                {
                    if (i < glb_settings.get_map_dim_parameter_x() / 2)
                        friend_foe[i, j] = (int)FriendFoeKind.friend;
                    else
                        friend_foe[i, j] = (int)FriendFoeKind.foe;
                }
            FriendFoe = friend_foe;

        }

        //generating the population
        public override void GeneratePopulation()
        {
            Random rnd = new Random();
            //initiate map arrays
            int[,] pop = new int[glb_settings.get_map_dim_parameter_x(), glb_settings.get_map_dim_parameter_y()];
            int[,] terra = new int[glb_settings.get_map_dim_parameter_x(), glb_settings.get_map_dim_parameter_y()];

            terra = MapTerrain;
            for (int i = 0; i < glb_settings.get_map_dim_parameter_x(); i++)
                for (int j = 0; j < glb_settings.get_map_dim_parameter_y(); j++)
                {
                    switch (terra[i, j])
                    {
                        case (int)TerrainKind.grass:
                            pop[i, j] = rnd.Next((int)PopulationSettings.minimal, (int)PopulationSettings.maximal);
                            break;
                        case (int)TerrainKind.city:
                            pop[i, j] = (int)PopulationSettings.city_factor * rnd.Next((int)PopulationSettings.minimal, (int)PopulationSettings.maximal);
                            break;
                        case (int)TerrainKind.water:
                            pop[i, j] = 0;
                            break;
                        case (int)TerrainKind.road:
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
                case (int)FriendFoeKind.friend:
                    label = "friend";
                    break;
                case (int)FriendFoeKind.foe:
                    label = "foe";
                    break;
            }

            return label;
        }

        //locate current position on a map grid, return false if out of the map
        public override PosXY GetPositionXY(int x, int y)
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

        public override void IsArmyInitialisation()
        {
            IsArmy = new bool[glb_settings.get_map_dim_parameter_x(), glb_settings.get_map_dim_parameter_y()];
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
                            terr[x, y] = (int)TerrainKind.grass;
                            x++;
                            break;
                        case 'w':
                            terr[x, y] = (int)TerrainKind.water;
                            x++;
                            break;
                        case 'r':
                            terr[x, y] = (int)TerrainKind.road;
                            x++;
                            break;
                        case 'c':
                            terr[x, y] = (int)TerrainKind.city;
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
            

        public override void GenerateArmy()
        {
            //infantry
            GenerateArmySideType((int)FriendFoeKind.friend, (int)ArmyType.light_infantry, GlobalParameters.ArmyUnitsQty[(int)ArmyType.light_infantry]);
            GenerateArmySideType((int)FriendFoeKind.foe, (int)ArmyType.light_infantry, GlobalParameters.ArmyUnitsQty[(int)ArmyType.light_infantry]);
            GenerateArmySideType((int)FriendFoeKind.friend, (int)ArmyType.heavy_infantry, GlobalParameters.ArmyUnitsQty[(int)ArmyType.heavy_infantry]);
            GenerateArmySideType((int)FriendFoeKind.foe, (int)ArmyType.heavy_infantry, GlobalParameters.ArmyUnitsQty[(int)ArmyType.heavy_infantry]);
            //cavalry
            GenerateArmySideType((int)FriendFoeKind.friend, (int)ArmyType.light_cavalry, GlobalParameters.ArmyUnitsQty[(int)ArmyType.light_cavalry]);
            GenerateArmySideType((int)FriendFoeKind.foe, (int)ArmyType.light_cavalry, GlobalParameters.ArmyUnitsQty[(int)ArmyType.light_cavalry]);
            GenerateArmySideType((int)FriendFoeKind.friend, (int)ArmyType.heavy_cavalry, GlobalParameters.ArmyUnitsQty[(int)ArmyType.heavy_cavalry]);
            GenerateArmySideType((int)FriendFoeKind.foe, (int)ArmyType.heavy_cavalry, GlobalParameters.ArmyUnitsQty[(int)ArmyType.heavy_cavalry]);
            //artillery
            GenerateArmySideType((int)FriendFoeKind.friend, (int)ArmyType.light_artillery, GlobalParameters.ArmyUnitsQty[(int)ArmyType.light_artillery]);
            GenerateArmySideType((int)FriendFoeKind.foe, (int)ArmyType.light_artillery, GlobalParameters.ArmyUnitsQty[(int)ArmyType.light_artillery]);
            GenerateArmySideType((int)FriendFoeKind.friend, (int)ArmyType.heavy_artillery, GlobalParameters.ArmyUnitsQty[(int)ArmyType.heavy_artillery]);
            GenerateArmySideType((int)FriendFoeKind.foe, (int)ArmyType.heavy_artillery, GlobalParameters.ArmyUnitsQty[(int)ArmyType.heavy_artillery]);
            //logistic
            GenerateArmySideType((int)FriendFoeKind.friend, (int)ArmyType.logistic, GlobalParameters.ArmyUnitsQty[(int)ArmyType.logistic]);
            GenerateArmySideType((int)FriendFoeKind.foe, (int)ArmyType.logistic, GlobalParameters.ArmyUnitsQty[(int)ArmyType.logistic]);
            //recruitement
            GenerateArmySideType((int)FriendFoeKind.friend, (int)ArmyType.recruitment, GlobalParameters.ArmyUnitsQty[(int)ArmyType.recruitment]);
            GenerateArmySideType((int)FriendFoeKind.foe, (int)ArmyType.recruitment, GlobalParameters.ArmyUnitsQty[(int)ArmyType.recruitment]);

        }

        private void GenerateArmySideType(int side, int army_type, int qty)
        {
            var rnd = new Random();


            while (qty > 0)
            {

                var pos = new PosXY();
                if (side == (int)FriendFoeKind.friend)
                {
                    pos.PosX = rnd.Next(0, glb_settings.get_map_dim_parameter_x() / 2 - 5);
                    pos.PosY = rnd.Next(0, glb_settings.get_map_dim_parameter_y());
                }
                else
                {
                    pos.PosX = rnd.Next(glb_settings.get_map_dim_parameter_x() / 2 + 5, glb_settings.get_map_dim_parameter_x());
                    pos.PosY = rnd.Next(0, glb_settings.get_map_dim_parameter_y());
                }
                if (!IsArmy[pos.PosX, pos.PosY]) //empty slot
                    if (MapTerrain[pos.PosX, pos.PosY] == (int)TerrainKind.grass || MapTerrain[pos.PosX, pos.PosY] == (int)TerrainKind.city) //not on roads or water
                    {
                        var army = new Army(side, army_type);
                        //create unit
                        ArmyUnits.Add(pos, army);
                        //mark on the map
                        IsArmy[pos.PosX, pos.PosY] = true;
                        qty--;
                    }
            }
        }
    }
}
