using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_7_Whats_new.Content
{
    public static class OutVariables
    {
        public static void TryParse_OldWay(string text)
        {
            int number;
            if (int.TryParse(text, out number))
            {
                // Do something...
            } 
        }

        public static void TryParse_NewWay(string text)
        {
            if(int.TryParse(text, out int number))
            {
                // Do something...
            }
        }
    }
}
