using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace allu
{
    //the map position class
    public class PosXY
    {
        public PosXY()
        {
            PosX = GlobalParameters.OutOfRange;
            PosY = GlobalParameters.OutOfRange;
        }
        public int PosX { get; set; }
        public int PosY { get; set; }
    }
}
