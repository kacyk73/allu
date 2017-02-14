using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace allu
{
    public abstract class map
    {

        //the terrain
        int[,] _terrain = new int[50, 40];

        public abstract void  Load_Map();
    }
}
