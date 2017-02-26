using System;
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
    public class terrain : map

    {


        //storing global class locally
        public glb_params glb_settings;

        public override void Load_Map()
        {
            //loading the map from the file 
            //the terrain type is stored in the enum
            //Terrain_Type

            string[] lines = System.IO.File.ReadAllLines(@"txt\map.txt");

            int[,] terr = new int [60, 40];

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
                            terr[x, y] = (int)Terrain_Type.grass;
                            x++;
                            break;
                        case 'w':
                            terr[x, y] = (int)Terrain_Type.water;
                            x++;
                            break;
                        case 'r':
                            terr[x, y] = (int)Terrain_Type.road;
                            x++;
                            break;
                        case 'c':
                            terr[x, y] = (int)Terrain_Type.city;
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
