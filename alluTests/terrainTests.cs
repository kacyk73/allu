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
        public void Load_MapTest()
        {
            //arrange
            terrain terra = new terrain();

            //act
            terra.Load_Map();
            var expected = (int)Terrain_Type.grass;

            //assert
            Assert.AreEqual(terra.MapTerrain[0,0] , expected);
        }
    }
}