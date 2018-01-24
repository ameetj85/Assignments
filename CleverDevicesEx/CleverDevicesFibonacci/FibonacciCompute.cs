using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleverDevicesFibonacci
{
    public class FibonacciCompute
    {
        public List<int> Fibonacci(int len)
        {
            List<int> values = new List<int>();

            int a = 0, b = 1, c = 0;

            values.Add(a);
            values.Add(b);
                
            for (int i = 2; i < len; i++)
            {
                c = a + b;
                values.Add(c);
                a = b;
                b = c;
            }

            return values;
        }
    }
}
