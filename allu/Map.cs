using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace allu
{
    /// <summary>
    /// defines properties for the map itself to be inherited by the terrain class later on
    /// </summary>
    public abstract class map
    {
        //the map array
        private int[,] _map_Terrain;


        public int[,] map_Terrain
        {
            get { return _map_Terrain; }
            set { _map_Terrain = value; }
        }


        public abstract void  Load_Map();
    }
}
