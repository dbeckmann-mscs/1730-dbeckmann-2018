using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace dbeckmann_2h1
{
    public class Ex2hCalculations
    {
        public static string DateCalc06(string strYear, string strMonth, string strDay)
        {
            string result = "Invalid input";
            DateTime date;
            try
            {
                int year = Int32.Parse(strYear);
                int month = Int32.Parse(strMonth);
                int day = Int32.Parse(strDay);
                date = new DateTime(year, month, day);
                result = date.ToShortDateString();
            }
            catch { }

            return result;
        }
        public static string DateCalc07(string strDate)
        {
            string result = "Invalid input";
            DateTime date;
            try
            {
                date = DateTime.Parse(strDate);
                result = date.ToShortDateString();
            }
            catch { }

            return result;
        }
        public static string DateCalc08(string strDate)
        {
            string result = "Invalid input";
            DateTime date;
            DateTime.TryParse(strDate, out date);

            result = date.ToShortDateString();
            return result;
        }
        public static string DateCalc09(string strDateA, string strDateB)
        {
            string result = "Invalid input";
            DateTime currentDate, dueDate;

            try
            {
                currentDate = DateTime.Parse(strDateA);
                dueDate = DateTime.Parse(strDateB);
                TimeSpan Days = currentDate.Subtract(dueDate);
                int difference = Days.Days;
                result = difference.ToString() + " days";
            }
            catch { }

            return result;
        }
        public static string DateCalc10(string strDateA, string strDateB)
        {
            string result = "Invalid input";
            DateTime currentDate, dueDate;

            try
            {
                currentDate = DateTime.Parse(strDateA);
                dueDate = DateTime.Parse(strDateB);

                if (currentDate > dueDate)
                {
                    currentDate = DateTime.Parse(strDateA);
                    dueDate = DateTime.Parse(strDateB);
                    TimeSpan Days = currentDate.Subtract(dueDate);
                    int difference = Days.Days;
                    result = difference.ToString() + " days past due";
                }
                if (currentDate <= dueDate)
                {
                    result = "On time";
                }
            }

            catch { }

            return result;
        }
        public static string StringCalc01(string s)
        {
            string result = "Invalid input";
            s = s.Trim();
            string str1 = s;
            
            try
            {
                s = str1.Remove(0, +1);
                s = s.Insert(0, "cr");
                result = s.ToString();


            }
            catch { }
            return result;
        }

        public static string StringCalc02(string s)
        {
            string result = "Invalid input";
            s = s.Trim();
            string str1 = s;
            try
            {
                s = str1.Remove(1, +1);
                s = s.Insert(1, "rit");
                result = s.ToString();
            }
            catch { }
            return result;
        }

        public static string StringCalc03(string s)
        {
             s = s.Trim();
            string result = "Invalid Input";
            string str1 = s;


            if (s.Length >= 6)
            {
                s = str1.Substring(2, 4).ToUpper();
                result = s.ToString();
            }
            else
                result = "Invalid input";
            
            
            return result;
        }

        public static string StringCalc04(string s)
        {
            s = s.Trim();
            string str1 = s;

            s = str1.PadLeft(10, '*' );
            return s.ToString();
        }
        public static string StringCalc05(string s)
        {
            s = s.Trim();
            string str1 = s;

            s = s.Replace("(", "");
            s = s.Replace(")", "");
            s = s.Replace(" ","");
            s = s.Replace("-", "");

            return s.ToString();
        }
        public static string StringCalc06(string s)
        {
            s = s.Trim();
            string result = "Invalid input";
            string str1 = s;

            s = str1.Replace("(", "");
            s = s.Replace(")", "");
            s = s.Replace(" ", "");
            s = s.Replace("-", "");

            try
            {
                if (s.Length == 10)
                {
                    s = s.Insert(3, ".");
                    s = s.Insert(7, ".");
                    result = s.ToString();
                }
                if (s.Length == 7)
                {
                    s = s.Insert(3, ".");
                    result = s.ToString();
                }
            }
            catch { };

            return result;    
        }
        public static string StringCalc07(string s)
        {
            string result =  "Not found";
            s = s.Trim();
            string str1 = s;

            s = str1.Substring(0).ToLower();
           
                if (s.Contains("pioneer"))
                {
                    result = "Found";
                }            
            
            return result;
        }
        //public static string StringCalc08(string s)
        //{
        //  string result = "Invalid input";  
        //string s;

        //    int s = s.IndexOf(",")
        //    s = s.Remove(0, 1);
        //    s = s.Substring(+1);



        //    return s.ToString();





        ////}
        //public static string StringCalc09(string s)
        //{
        //    string result = "Invalid input";
        //    string str1 = s;

        //    try
        //    {
        //       s = (s.LastIndexOf(" "));





        //    }

        //}
        //public static string StringCalc10(string s1, string s2, string s3)
        //{
        //    StringBuilder sb = new Stringbuilder(100);

        //}


    }
}