using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace allu
{
    public abstract class map
    {

        //the terrain array
        int[,] _terrain = new int[60, 40];

        public int [,] GetTerrain()
        {
            return _terrain;
        }

        public void SetTerrain(int [,] terr)
        {
            _terrain = terr;
        }

        public abstract void  Load_Map();
    }
}
