using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_7_Whats_new.Content
{
    public class Deconstruction
    {
        public static void TupleDeconstruct()
        {
            (double lat, double lon) = Tuples.GetGpsCoords();
            // (var lat, var lon) = Tuples.GetGpsCoords(); // var inside
            // var (lat, lon) = Tuples.GetGpsCoords(); // var outside
            // (lat, lon) = Tuples.GetGpsCoords(); // from method declaration

            ShowOnMap(lat, lon);
        }

        private static void ShowOnMap(double lat, double lon)
        {
            throw new NotImplementedException();
        }

        class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }

            public void Deconstruct(out string name, out int age)
            {
                name = Name;
                age = Age;
            }
            
        }

        public void DeconstructPerson()
        {
            var person = new Person("Darek", 29);
            var (name, age) = person;
        }
    }
}
