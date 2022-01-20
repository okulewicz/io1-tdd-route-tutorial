using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO1RouteLib
{
    public class LocationWithAddress : Location
    {
        public LocationWithAddress(double x, double y, string street, string city, string postal, string buildingId) : base(x, y)
        {
            Street = street;
            City = city;
            Postal = postal;
            BuildingId = buildingId;
        }

        public string Street { get; }
        public string City { get; }
        public string Postal { get; }
        public string BuildingId { get; }
    }
}
