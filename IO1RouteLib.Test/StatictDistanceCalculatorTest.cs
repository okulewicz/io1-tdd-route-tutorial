using IO1RouteLib.DistanceProviders;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO1RouteLib.Test
{
    [TestClass]
    public class StatictDistanceCalculatorTest
    {
        [TestMethod]
        public void StaticDistanceTest()
        {
            double expectedDistance = 2.0;
            Location location1 = new BaseLocation(0.0, 0.0);
            Location location2 = new BaseLocation(1.0, 0.0);
            Location location3 = new BaseLocation(13.0, 15.0);

            IDistanceCalculator staticDistance = new StatictDistanceCalculator(3.0);

            Assert.AreEqual(expectedDistance, staticDistance.GetDistance(location1, location2));
            Assert.AreEqual(expectedDistance, staticDistance.GetDistance(location2, location3));
            Assert.AreEqual(expectedDistance, staticDistance.GetDistance(location3, location1));
        }
    }
}
