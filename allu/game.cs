using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace allu
{
    /// <summary>
    /// the game methods
    /// </summary>
    public abstract class game
    {
        public abstract void Draw_Grid();
        public abstract void Draw_Border_Initial();
        public abstract void Draw_Map(int [,] terra);
    }
}
