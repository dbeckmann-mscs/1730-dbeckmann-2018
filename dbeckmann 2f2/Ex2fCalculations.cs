using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbeckmann_2f2
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
        public static string Calc02(string input)
        {
            // #2 if block
            decimal subtotal = 0m;
            decimal discountPercent = 0m;
            subtotal = decimal.Parse(input);
            discountPercent = 0m;
            string status = "Standard rate: ";

            if (subtotal >= 100m)
            {
                discountPercent = 0.2m;
                status = "Bulk rate: " + discountPercent.ToString("n2");
            }
            return status;
        }

        public static string Calc03(string input)
        {
            // #3 if else
            decimal subtotal = 0m;
            decimal discountPercent = 0m;
            subtotal = decimal.Parse(input);
            discountPercent = 0m;
            if (subtotal >= 100m)
                discountPercent = 0.2m;
            else
                discountPercent = 0.1m;
            return discountPercent.ToString("n2");
        }

        public static string Calc04(string input)
        {
            // #4 if else if
            decimal subtotal = 0m;
            decimal discountPercent = 0m;
            subtotal = decimal.Parse(input);
            discountPercent = 0m;
            if (subtotal >= 100 && subtotal < 200)
                discountPercent = 0.2m;
            else if (subtotal >= 200 && subtotal < 300)
                discountPercent = 0.3m;
            else if (subtotal >= 300)
                discountPercent = 0.4m;
            else
                discountPercent = 0.1m;
            return discountPercent.ToString("n2");
        }

        public static string Calc05(string input)
        {
            // #5 Better range test
            decimal subtotal = 0m;
            decimal discountPercent = 0m;
            subtotal = decimal.Parse(input);
            discountPercent = 0m;
            if (subtotal >= 300)
                discountPercent = 0.4m;
            else if (subtotal >= 200)
                discountPercent = 0.3m;
            else if (subtotal >= 100)
                discountPercent = 0.2m;
            else
                discountPercent = 0.1m;
            return discountPercent.ToString("n2");
        }

        public static string Calc06(string inputA, string inputB)
        {
            // #6 Nested if
            decimal subtotal = 0m;
            decimal discountPercent = 0m;
            subtotal = decimal.Parse(inputA);
            string customerType = inputB;
            discountPercent = 0m;
            if (customerType == "R")
            {
                if (subtotal >= 100)
                    discountPercent = 0.2m;
                else
                    discountPercent = 0.1m;
            }
            else
                discountPercent = 0.4m;
            return discountPercent.ToString("n2");
        }

        public static string Calc07(string input)
        {
            // #7 Validate input: non-empty string
            decimal ethereum = 0m;
            if (input != "")
            {
                decimal dollars = decimal.Parse(input);
                ethereum = 200m * dollars;
                return ethereum.ToString("n2");
            }

            return "Invalid input";
        }

        public static string Calc08(string inputA, string inputB)
        {
            // #8 Validate input, calculate quantity * price, shipping
            decimal total = 0m;
            decimal subtotal = 0m;
            
                if (inputA != "" && inputB != "")
            { 
                decimal price = decimal.Parse(inputA);
                decimal quantity = decimal.Parse(inputB);
                subtotal = price * quantity;

                if (subtotal < 50m)
                    total = subtotal + 5m;

                else
                    total = subtotal;

                return total.ToString("n2");
            }

            return "Invalid input"; 
        }

        public static string Calc09(string inputA, string inputB)
        {
            // #9 Validate input, calculate difference * rate
            decimal subtotal = 0m;
            decimal total = 0m;

            if (inputA != "" && inputB != "")
            {
                decimal begin = decimal.Parse(inputA);
                decimal end = decimal.Parse(inputB);
                subtotal = end - begin;

                total = subtotal * 0.1m;
                 if (total >= 0m) 
                    return total.ToString("n2");
                 else 

                 return "Invalid input";
            }

            return "Invalid input";
        }

        public static string Calc10(string inputA, string inputB)
        {
            // #10 Validate input, divide large num by small
            //     Both numbers must be > 0
            decimal total = 0m;

            if (inputA != "" && inputB != "")
            if (inputA != "0" && inputB != "0")
            {
                
               decimal DataA = decimal.Parse(inputA);
               decimal DataB = decimal.Parse(inputB);

                   
                    
                        if (DataA >= DataB)
                        total = DataA / DataB;

                        else if (DataA <= DataB)
                        total = DataB / DataA;

                        return total.ToString("n2");
               ;
            }

            return "Invalid input";

        }
    }
}
