using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_7_Whats_new.Content
{
    public class Tuples
    {
        public static (double lat, double lon) GetGpsCoords()
        {
            // PGS Wroclaw office.
            var latitude = 51.105926;
            var longitude = 16.971205;

            return (lat: latitude, lon: longitude);
        }
        
        private void Usage()
        {
            var coords = GetGpsCoords();
            Console.WriteLine($"Latitude: {coords.lat}, Longitude: {coords.lon}");
        }
    }
}
