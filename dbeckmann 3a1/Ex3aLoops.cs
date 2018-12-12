using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbeckmann_3a1
{
    public class Ex3aLoops
    {
        //public static string Calc0()
        //{
        //    int i = 1, sum = 0;
        //    while (i < 5)
        //    {
        //        sum += i;
        //        i++;
        //    }
        //    return sum.ToString();
        //}

        public static string Calc0(string strMonth, string strMonthlyPayment, string strMonthlyInterestRate)
        {
            double futureValue = 0.0;
            try
            {
                int months = Int32.Parse(strMonth);
                double monthlyPayment = double.Parse(strMonthlyPayment);
                double monthlyInterestRate = double.Parse(strMonthlyInterestRate);
                int i = 1;
                while (i <= months)
                {
                    futureValue = (futureValue + monthlyPayment) * (1 + monthlyInterestRate);
                    i++;
                }
            }
            catch
            {
                return "Invalid input";
            }
            return futureValue.ToString("n2");
        }

        public static string Calc1(string strMonth, string strMonthlyPayment, string strMonthlyInterestRate)
        {
            double futureValue = 0.0;
            try
            {
                int months = Int32.Parse(strMonth);
                double monthlyPayment = double.Parse(strMonthlyPayment);
                double monthlyInterestRate = double.Parse(strMonthlyInterestRate);
                int i = 1;
                do
                {
                    futureValue = (futureValue + monthlyPayment) * (1 + monthlyInterestRate);
                    i++;
                }
                while (i <= months);
            }
            catch
            {
                return "Invalid input";
            }
            return futureValue.ToString("n2");
        }
        public static string Calc2(string strMonth, string strMonthlyPayment, string strMonthlyInterestRate)
        {
            double futureValue = 0.0;
            try
            {
                int months = Int32.Parse(strMonth);
                double monthlyPayment = double.Parse(strMonthlyPayment);
                double monthlyInterestRate = double.Parse(strMonthlyInterestRate);
                for (int i = 1; i <= months; i++)
                {
                    futureValue = (futureValue + monthlyPayment) * (1 + monthlyInterestRate);

                }
            }
            catch
            {
                return "Invalid input";
            }
            return futureValue.ToString("n2");
        }
        public static string Calc3(string strStart, string strEnd, string strIncrement)
        {
            string result = "";
            string numbers = "";

            try
            {
                int increment = Int32.Parse(strIncrement);
                if (increment <= 0) throw new Exception();
                int start = Int32.Parse(strStart);
                int end = Int32.Parse(strEnd);
                for (int i = start; i < end; i++)

            while (i < end)
            {
                        numbers += i  +" ";
                        i += increment;
            }
            result = numbers.ToString();
            }
            catch
            {
                result = "Invalid input";
            }   

            return result;
        }

        public static string Calc4(string strStart, string strEnd, string strIncrement)
        {
            string result = "";
            string numbers = "";

            try
            {
                int increment = Int32.Parse(strIncrement);
                int start = Int32.Parse(strStart);
                int end = Int32.Parse(strEnd);
                if (increment <= 0) throw new Exception();
                if (start <= 0) throw new Exception();
                
                int i = start; 
                do
                {
                    numbers += i + " ";
                    i += increment;
                    result = numbers.ToString();
                }
                while (i < end);
                i++;
            }
            catch
            {
                result = "Invalid input";
            }
                 
            
            return result;
        }

        public static string Calc5(string strStart, string strEnd, string strIncrement)
        {
            string result = "";
            string numbers = "";


            try
            {
                int increment = Int32.Parse(strIncrement);
                if (increment <= 0) throw new Exception();
                int start = Int32.Parse(strStart);
                int end = Int32.Parse(strEnd);
                for (int i = start; i < end; i += increment)
                {
                    numbers += i + " ";
                    
                }
                   result = numbers.ToString();
            }
            catch
            {
                result = "Invalid input";
            }
               return result;            
         }       

        public static string Calc6(string strNumbers, string strCount)
        {
            string result = "";
            int startIndex = 0;
            int sum = 0;            
            int count = Int32.Parse(strCount);
            int i = count;

            try
            {
                while (i <= count)
                {
                    int endIndex = strNumbers.IndexOf(' ', startIndex);
                    string strNumber = strNumbers.Substring(startIndex, endIndex - startIndex);
                    int number = Int32.Parse(strNumbers);
                    sum += number;
                    startIndex = endIndex + 1;

                }
                result = sum.ToString();
            }
            catch
            {
                result = "Invalid input";
            }
            return result;
        }

        public static string Calc7(string strNumbers, string strCount)
        {
            string result = "";

            return result;
        }

        public static string Calc8(string strNumbers, string strCount)
        {
            string result = "";

            return result;
        }
    }
}
