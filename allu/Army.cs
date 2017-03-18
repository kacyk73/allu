using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace allu
{
    public class Army
    {
        public Army(int side)
        {
            armySide = side;
        }
        private int armySide;

        public int ArmySide
        {
            get { return armySide; }
            set { armySide = value; }
        }

    }
}

