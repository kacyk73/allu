using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace allu
{

    //terrain type
    public enum TerrainKind
    {
        grass = 1,
        water = 2,
        city = 3,
        road = 4
    }

    //friend-foe definition
    public enum FriendFoeKind
    {
        friend = 1,
        foe = 2
    }

    /// <summary>
    /// the game global settings
    /// </summary>
    public class GlobalParameters
    {
        //map dimentions
        private int map_dim_x;
        private int map_dim_y;
        //box size
        private int map_box_size = 20;
        //menu size
        private int map_menu_offset = 200;

        //out of range parameter
        public const int OutOfRange = 999;

        public void set_map_dim_parameters(int x, int y)
        {
            map_dim_x = x;
            map_dim_y = y;
        }

        public int get_map_dim_parameter_x()
        {
            return map_dim_x;
        }

        public int get_map_dim_parameter_y()
        {
            return map_dim_y;
        }

        public int get_map_box_size()
        {
            return map_box_size;
        }

        public int get_map_menu_offset()
        {
            return map_menu_offset;
        }


    }
}
