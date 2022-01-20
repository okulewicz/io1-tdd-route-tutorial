using System;
using System.Collections.Generic;

namespace IO1RouteLib
{
    public class Route
    {
        List<Location> _waypoints;
        private IDistanceCalculator _distanceCalculator;

        public double Length { get; private set; }
        public int WaypointsCount => _waypoints.Count;

        public Route(IDistanceCalculator distanceCalculator)
        {
            _distanceCalculator = distanceCalculator;
            _waypoints = new List<Location>();
        }

        public void AddWaypoint(Location location)
        {
            _waypoints.Add(location);
            if (_waypoints.Count > 1)
            {
                double distanceBetweenLastTwoPoints = _distanceCalculator.GetDistance(
                    _waypoints[WaypointsCount - 2],
                    _waypoints[WaypointsCount - 1]);
                Length += distanceBetweenLastTwoPoints;
            }
        }
    }
}
