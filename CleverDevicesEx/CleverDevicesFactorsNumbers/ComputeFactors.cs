using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleverDevicesFactorsNumbers
{
    public class ComputeFactors
    {
        public List<int> FactorsCompute(int num)
        {
            int x = 0;
            List<int> factors = new List<int>();

            for (x = 1; x <= num; x++)
            {
                if (num % x == 0)
                {
                    factors.Add(x);
                }
            }

            return factors;
        }
    }
}
