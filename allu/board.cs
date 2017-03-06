
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace allu
{

    //the game main form class
    public partial class Board : Form
    {

        //the game is on
        bool GameIsOn = false;

        //storing global class locally
        public GlobalParameters glb_settings;

        //invoke map position class
        private Map.PosXY currentPositionXY;

        public Map.PosXY CurrentPositionXY
        {
            get { return currentPositionXY; }
            set { currentPositionXY = value; }
        }

        //invoke the terrain
        private Terrain terra;

        public Terrain Terra
        {
            get { return terra; }
            set { terra = value; }
        }

        //invoke drawing class
        private DrawElements drawer;

        public DrawElements Drawer
        {
            get { return drawer; }
            set { drawer = value; }
        }

        public Board()
        {

            InitializeComponent();

            //draw temporary start button
            btn_start2.SetBounds(1220, 550, 60, 30);

            //call local objects
            this.Terra = new Terrain();

        }

        private void btn_start2_Click(object sender, EventArgs e)
        {
            //the game entry point
            GameIsOn = true;

            //local settings for global variables
            Terra.glb_settings = glb_settings;

            //drawer = new DrawElements(CreateGraphics());
            Drawer.glb_settings = glb_settings;
            //var x = CreateGraphics();
            Drawer.Draw_Grid();
            Drawer.Draw_Border_Initial();

            //load the terrain from files
            Terra.Load_Map();

            //generate the random population
            terra.GeneratePopulation();

            //friend-foe initialisation
            Terra.FriendFoeInitialisation();

            //draw the whole map
            Drawer.Draw_Map(Terra.MapTerrain);

            //start button disable
            btn_start2.Visible = false;

        }

        private void Board_DoubleClick(object sender, EventArgs e)
        {

        }

        private void Board_Load(object sender, EventArgs e)
        {
            //set actual graphics to drawer
            Drawer = new DrawElements(CreateGraphics());
        }

        private void Board_MouseHover(object sender, EventArgs e)
        {

        }

        private void Board_MouseMove(object sender, MouseEventArgs e)
        {
            if (GameIsOn)
            {

                //get current mouse position in map grid values
                var TempPositionXY = new Map.PosXY();
                TempPositionXY = terra.GetPositionXY(e.X, e.Y);
                if (CurrentPositionXY != TempPositionXY)
                    if ((TempPositionXY.PosX != GlobalParameters.OutOfRange) && (TempPositionXY.PosY != GlobalParameters.OutOfRange))
                    {
                        CurrentPositionXY = TempPositionXY;
                        textBox1.Text = Convert.ToString(Convert.ToInt32(CurrentPositionXY.PosX));
                        labely.Text = Convert.ToString(Convert.ToInt32(CurrentPositionXY.PosY));

                        //friend foe label
                        lblFriendFoe.Text = terra.GetLabelsFriendFoe(terra.FriendFoe[CurrentPositionXY.PosX, CurrentPositionXY.PosY]);
                        //population label
                        lbl_population.Text = Convert.ToString(terra.Population[CurrentPositionXY.PosX, CurrentPositionXY.PosY]);
                    }
                    else
                    {
                        //temporary debugging 45
                        textBox1.Text = Convert.ToString(999);

                        //friend foe label
                        lblFriendFoe.Text = "";
                    }
                    
            }

        }
    }
}
