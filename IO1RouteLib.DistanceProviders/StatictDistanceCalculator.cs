namespace IO1RouteLib.DistanceProviders
{
    public class StatictDistanceCalculator : IDistanceCalculator
    {
        private readonly double _distanceConst;

        public StatictDistanceCalculator(double distanceConst)
        {
            _distanceConst = distanceConst;
        }

        public double GetDistance(Location location1, Location location2)
        {
            return _distanceConst;
        }
    }
}