using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace allu
{
    public class Army
    {
        public Army(int side, int army_type)
        {
            armySide = side;
            armyType = army_type;
        }

        private int armySide;

        public int ArmySide
        {
            get { return armySide; }
            set { armySide = value; }
        }

        private int armyType;

        public int ArmyType
        {
            get { return armyType; }
            set { armyType = value; }
        }


    }
}

