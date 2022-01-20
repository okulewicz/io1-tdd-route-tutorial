using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IO1RouteLib.Test
{
    [TestClass]
    public class RouteTest
    {
        [TestMethod]
        public void CorrectRouteLength()
        {
            double expectedEmptyRouteLength = 0.0;
            Route route = new Route();
            Assert.AreEqual(expectedEmptyRouteLength, route.Length);

            double expectedRouteWithSinglePointLength = 0.0;
            int expectedWaypointsCountInRouteWithSinglePoint = 1;
            Location location1 = new Location(0.0, 0.0);
            route.AddWaypoint(location1);
            Assert.AreEqual(expectedWaypointsCountInRouteWithSinglePoint, route.WaypointsCount);
            Assert.AreEqual(expectedRouteWithSinglePointLength, route.Length);

            double expectedRouteWithTwoPointsLength = 1.0;
            int expectedWaypointsCountInRouteWithTwoPoints = 2;
            Location location2 = new Location(1.0, 0.0);
            route.AddWaypoint(location2);
            Assert.AreEqual(expectedWaypointsCountInRouteWithTwoPoints, route.WaypointsCount);
            Assert.AreEqual(expectedRouteWithTwoPointsLength, route.Length);
        }
    }
}
