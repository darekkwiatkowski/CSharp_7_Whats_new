using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_7_Whats_new.Content
{
    public class Patterns
    {
        #region Helper classes
        class Person {
            public string Name;
            public int Age;
        }

        class Animal
        {
            public AnimalType Type;
        }

        enum AnimalType { Cat, Dog, Hamster }
        #endregion

        public static void IsExpressionsOldWay(object obj)
        {
            if(obj is Person)
            {
                // Do something...
            }

            var p = obj as Person;
            if(p != null)
            {
                // Do something...
            }
        }
        public static void IsExpressions(object obj)
        {
            if (obj is null) return;            // Constant pattern
            if (!(obj is Person p)) return;     // Type pattern

            // Do something with the Person object...
            p.Name = "Darek";
            p.Age = 29;
        }

        public static void SwitchCase(object obj)
        {
            switch(obj)
            {
                case Person p:
                    Console.WriteLine("Name: " + p.Name);
                    break;

                case Animal a when (a.Type == AnimalType.Cat):
                    Console.WriteLine("Type: " + a.Type);
                    break;

                default:
                    throw new Exception("Unknown type!");
            }
        }
    }
}
