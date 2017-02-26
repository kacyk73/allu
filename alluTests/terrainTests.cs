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
    public class TerrainTests
    {
        [TestMethod()]
        public void Load_MapTest()
        {
            //arrange
            Terrain terra = new Terrain();

            //act
            terra.Load_Map();
            var expected = (int)Terrain_Type.grass;

            //assert
            Assert.AreEqual(terra.MapTerrain[0,0] , expected);
        }
    }
}