using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_7_Whats_new.Content
{
    public class ExpressionBodiedMembers
    {
        class Person
        {
            public Person(string name) => _name = name;
            
            private string _name;
            
            public string Name
            {
                get => _name;
                set => _name = "Mr. " + value;
            }

            // Available in C# 6.0:
            // public string Name => _name;
        }
    }
}
