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
    public abstract class Game
    {
        //graphical board elements
        public abstract void DrawGrid();
        public abstract void DrawBorderInitial();
        public abstract void DrawMap(int [,] terra);

        //army elements
        public abstract void DrawArmyXY(PosXY pos, Terrain Terra);
        public abstract void DrawArmy(Terrain Terra);
        
    }
}
