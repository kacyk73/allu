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
    public partial class board : Form 
    {

        //storing global class locally
        public glb_params glb_settings;

        public board()
        {

            InitializeComponent();

            //draw temporary start button
            btn_start2.SetBounds(1220, 50, 60, 30);
        }

        private void btn_start2_Click(object sender, EventArgs e)
        {
            //the game entry point
            //invoke the terrain
            terrain terra = new terrain();
            terra.glb_settings = glb_settings;

            //string path = Directory.GetCurrentDirectory();
            //textBox1.Text = path;

            //invoke drawing class
            draw_elements drawer = new draw_elements(CreateGraphics());
            drawer.glb_settings = glb_settings;
            var x = CreateGraphics();
            drawer.Draw_Grid();
            drawer.Draw_Border_Initial();

            //load the terrain from files
            terra.Load_Map();

            //draw the whole map
            drawer.Draw_Map(terra.MapTerrain);

            //start button disable
            btn_start2.Enabled = false;
        }
    }
}
