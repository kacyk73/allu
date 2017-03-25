using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace allu
{

    //game status
    public enum GameStatusList
    {
        peace = 1,
        protecting = 2,
        war = 3,
        post_war = 4
    }

    //army types
    public enum ArmyType
    {
        light_infantry = 1,
        heavy_infantry = 2,
        light_cavalry = 3,
        heavy_cavalry = 4,
        light_artillery = 5,
        heavy_artillery = 6,
        logistic = 7,
        recruitment = 8
    }

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

    //population initial settings
    public enum PopulationSettings
    {
        minimal = 1000,
        maximal = 5000,
        city_factor = 20

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

        public static readonly string[] ArmyTypeLabels = { "Light Infantry", "Heavy Infantry", "Light Cavalry", "Heavy Cavalry", "Light Artillery", "Heavy Artilery", "Logistics", "Recruitement" };

        public static readonly Dictionary<int, int> ArmyUnitsQty = new Dictionary<int, int>
        {
            [(int)ArmyType.light_infantry] = 100,
            [(int)ArmyType.heavy_infantry] = 10,
            [(int)ArmyType.light_cavalry] = 10,
            [(int)ArmyType.heavy_cavalry] = 10,
            [(int)ArmyType.light_artillery] = 10,
            [(int)ArmyType.heavy_artillery] = 10,
            [(int)ArmyType.logistic] = 10,
            [(int)ArmyType.recruitment] = 10
        };
    }
}
