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
        //army dictionary
        //private Dictionary<PosXY, Army> dicArmy;

        public Dictionary<PosXY, Army> DicArmy = new Dictionary<PosXY, Army>();
        //{
        //    get { return dicArmy; }
        //    set { dicArmy = value; }
        //}


        //the population array
        private int[,] population;

        public int[,] Population
        {
            get { return population; }
            set { population = value; }
        }

        //the map array
        private int[,] mapTerrain;

        public int[,] MapTerrain
        {
            get { return mapTerrain; }
            set { mapTerrain = value; }
        }

        //the friend-foe on the map identification
        private int[,] friendFoe;

        public int[,] FriendFoe
        {
            get { return friendFoe; }
            set { friendFoe = value; }
        }

        public abstract void Load_Map();
        public abstract void GeneratePopulation();
        public abstract void FriendFoeInitialisation();
        public abstract PosXY GetPositionXY(int x, int y);
        public abstract string GetLabelsFriendFoe(int i);
    }
}
