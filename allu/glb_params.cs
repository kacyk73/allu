using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace allu
{
    public class glb_params
    {
        private int map_dim_x;
        private int map_dim_y;
        private int map_box_size = 20;
        private int map_menu_offset = 200;

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
