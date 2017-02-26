using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace allu
{
    /// <summary>
    /// map class
    /// </summary>
    public abstract class Map
    {
        //the map array
        private int[,] mapTerrain;


        public int[,] MapTerrain
        {
            get { return mapTerrain; }
            set { mapTerrain = value; }
        }


        public abstract void  Load_Map();
    }
}
