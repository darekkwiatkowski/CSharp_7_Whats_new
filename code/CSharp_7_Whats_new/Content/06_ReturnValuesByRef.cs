using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_7_Whats_new.Content
{
    public class ReturnValuesByRef
    {
        private int[] numbers = { 1, 3, 9, 12, 15 };

        public ref int GetSecondNumber()
        {
            return ref numbers[1];
        }
        // (...)
        private void Usage()
        {
            ref int number = ref GetSecondNumber();
            number = 44;

            Console.WriteLine(numbers[1]);
        }
    }
}
