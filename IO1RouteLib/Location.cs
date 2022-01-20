namespace IO1RouteLib
{
    public abstract class Location
    {
        public Location(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double X { get; }
        public double Y { get; }
    }
}