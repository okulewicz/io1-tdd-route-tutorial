using System;

namespace IO1RouteLib
{
    internal class DistanceCalculator
    {
        internal double GetDistance(Location location1, Location location2)
        {
            return Math.Sqrt((location1.X - location2.X) * (location1.X - location2.X) +
                (location1.Y - location2.Y) * (location1.Y - location2.Y));
        }
    }
}