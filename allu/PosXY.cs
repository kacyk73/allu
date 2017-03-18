using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace allu
{
    //the map position class
    public class PosXY: IEquatable<PosXY>
    {
        public PosXY()
        {
            PosX = GlobalParameters.OutOfRange;
            PosY = GlobalParameters.OutOfRange;
        }
        public int PosX { get; set; }
        public int PosY { get; set; }

        // override object.Equals
        public bool Equals(PosXY other)
        {
            return this.PosX == other.PosX && this.PosY == other.PosY;
            //return base.Equals(obj);
        }

        public override bool Equals(object obj)
        {
            if (obj is PosXY)
                return Equals((PosXY)obj);
            else
                return false;
        }

        public override int GetHashCode()
        {
            return PosX.GetHashCode() ^ PosY.GetHashCode();
        }
    }
}
