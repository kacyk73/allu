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
        public Dictionary<PosXY, Army> ArmyUnits = new Dictionary<PosXY, Army>();

        //army helper array for performance purposes 12343xh fd xs fsf scsdd ss sd sfdh vdd dssddcf xsrd7 sddcddcds ds dcsss ffc

        public bool[,] IsArmy
        {
            get { return IsArmy; }
            set { IsArmy = value; }
        }


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

        //game status
        private int gameStatus;

        public int GameStatus
        {
            get { return gameStatus; }
            set { gameStatus = value; }
        }


        public abstract void Load_Map();
        public abstract void GeneratePopulation();
        public abstract void FriendFoeInitialisation();
        public abstract PosXY GetPositionXY(int x, int y);
        public abstract string GetLabelsFriendFoe(int i);
        public abstract void IsArmyInitialisation();
        public abstract void GenerateArmy();
    }
}
