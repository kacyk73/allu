using Microsoft.VisualStudio.TestTools.UnitTesting;
using allu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace allu.Tests
{
    [TestClass()]
    public class terrainTests
    {
        [TestMethod()]
        public void FriendFoeInitialisationTest()
        {
            //arrange
            Terrain terra = new Terrain();
            GlobalParameters glb_settings = new GlobalParameters();
            glb_settings.set_map_dim_parameters(60, 40);
            terra.glb_settings = glb_settings;

            //act
            terra.FriendFoeInitialisation();
            var expected = (int)FriendFoeKind.foe;

            //assert
            Assert.AreEqual(terra.FriendFoe[30, 0], expected);
        }
    }

    [TestClass()]
    public class TerrainTests
    {
        [TestMethod()]
        public void Load_MapTest()
        {
            //arrange
            Terrain terra = new Terrain();
            GlobalParameters glb_settings = new GlobalParameters();
            glb_settings.set_map_dim_parameters(60, 40);
            terra.glb_settings = glb_settings;

            //act
            terra.Load_Map();
            var expected = (int)TerrainKind.grass;

            //assert
            Assert.AreEqual(terra.MapTerrain[0, 0], expected);
        }
    }
}