using System;

namespace IO1RouteLib.DistanceProviders
{
    public class DistanceCalculator : IDistanceCalculator
    {
        public double GetDistance(Location location1, Location location2)
        {
            return Math.Sqrt((location1.X - location2.X) * (location1.X - location2.X) +
                (location1.Y - location2.Y) * (location1.Y - location2.Y));
        }
    }
}