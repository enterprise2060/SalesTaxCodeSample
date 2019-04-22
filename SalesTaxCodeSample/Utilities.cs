using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTaxCodeSample
{
    public static class Utilities
    {
        public static decimal Round(decimal input)
        {
            var ceilingValue = Math.Ceiling(input * 20);
            if (ceilingValue == 0)
            {
                return 0;
            }
            return ceilingValue / 20;
        }

        public static string FormattedAmount(decimal input)
        {
            return input.ToString("0.00");
        }
    }
}
