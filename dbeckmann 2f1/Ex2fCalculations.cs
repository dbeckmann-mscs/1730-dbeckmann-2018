using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbeckmann_2f1
{
    public class Ex2fCalculations
    {
        public static string Calc01(string input)
        {
            // #1 if
            decimal subtotal = 0m;
            decimal discountPercent = 0m;
            subtotal = decimal.Parse(input);
            if (subtotal >= 100m)
                discountPercent = 0.2m;
            return discountPercent.ToString("n2");
        }

    }
}
