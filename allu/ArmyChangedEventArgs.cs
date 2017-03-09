using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace allu
{
    public class ArmyChangedEventArgs : EventArgs
    {
        public ArmyChangedEventArgs(int ii, float jj)
        {
            i = ii;
            j = jj;
        }
        public int i { get; set; }
        public float j { get; set; }
    }
}
