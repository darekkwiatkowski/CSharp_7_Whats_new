using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_7_Whats_new.Content
{
    public class FibonacciCalculator
    {
        public static int Fibonacci(int x)
        {
            if (x < 0)
            {
                throw new ArgumentException("Be positive! :-)", nameof(x));
            }

            return Fib(x).current;  // Calling local function here.

            // Local function definition.
            (int current, int previous) Fib(int i)
            {
                if (i == 0) return (1, 0);
                var (p, pp) = Fib(i - 1);
                return (p + pp, p);
            }
        }
    }
}
