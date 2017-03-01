
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

        //storing global class locally
        public GlobalParameters glb_settings;

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
            btn_start2.SetBounds(1220, 50, 60, 30);

            //call local objects
            this.Terra = new Terrain();

        }

        private void btn_start2_Click(object sender, EventArgs e)
        {
            //the game entry point
            //local settings for global variables
            Terra.glb_settings = glb_settings;

            //drawer = new DrawElements(CreateGraphics());
            Drawer.glb_settings = glb_settings;
            //var x = CreateGraphics();
            Drawer.Draw_Grid();
            Drawer.Draw_Border_Initial();

            //load the terrain from files
            Terra.Load_Map();

            //friend-foe initialisation
            Terra.FriendFoeInitialisation();

            //draw the whole map
            Drawer.Draw_Map(Terra.MapTerrain);

            //start button disable
            btn_start2.Enabled = false;
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
            textBox1.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) + 1);

            //object[] ddd = new object[4];
        }
    }
}
