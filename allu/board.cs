
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

    //the game main form
    public partial class Board : Form 
    {

        //storing global class locally
        public GlobalParameters glb_settings;

        ///invoke the terrain
        Terrain terra;

        //invoke drawing class
        DrawElements drawer;

        public Board()
        {

            InitializeComponent();

            //draw temporary start button
            btn_start2.SetBounds(1220, 50, 60, 30);

            //call local objects
            this.terra = new Terrain();
        }

        private void btn_start2_Click(object sender, EventArgs e)
        {
            //the game entry point
            //local settings for global variables
            terra.glb_settings = glb_settings;

            //drawer = new DrawElements(CreateGraphics());
            drawer.glb_settings = glb_settings;
            //var x = CreateGraphics();
            drawer.Draw_Grid();
            drawer.Draw_Border_Initial();

            //load the terrain from files
            terra.Load_Map();

            //friend-foe initialisation
            terra.FriendFoeInitialisation();

            //draw the whole map
            drawer.Draw_Map(terra.MapTerrain);

            //start button disable
            btn_start2.Enabled = false;
        }

        private void Board_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void Board_Load(object sender, EventArgs e)
        {
            //set actual graphics to drawer
            drawer = new DrawElements(CreateGraphics());
        }
    }
}
