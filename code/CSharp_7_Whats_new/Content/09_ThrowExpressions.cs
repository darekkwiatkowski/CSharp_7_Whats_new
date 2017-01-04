using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_7_Whats_new.Content
{
    public class ThrowExpressionExample
    {
        public void Previously()
        {
            var colorString = "green,red,blue".Split(',');
            var colors = (colorString.Length > 0) ? colorString : null;

            if (colors == null)
            {
                throw new Exception("The list is empty!");
            }
        }

        public void Now()
        {
            var colorString = "green,red,blue".Split(',');
            var colors = (colorString.Length > 0) ? 
                colorString : 
                throw new Exception("The list is empty!");
        }

        // Method
        public void SomeNotImplementedMethod() => throw new NotImplementedException();


        // Property
        private string _name;
        public string Name => _name ?? throw new ArgumentNullException(_name);
    }
}
