using System;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //lesson1
            /*
            string hello = "hi";
            Console.WriteLine("Hello World!");
            Console.WriteLine(hello);
            Console.Write("123");
            Console.Write("456");
            string text = Console.ReadLine();
            Console.WriteLine(text);
            */

            //lesson2
            /*
            int a = 5;
            int b = 4;
            int c = a + b;
            Console.WriteLine(c);

            //type convert
            string str = "2";
            string str2 = "3";
            Console.WriteLine(str + str2);
            
            //Convert.ToInt32 -> int
            //Convert.ToInt16 -> short

            int aa = Convert.ToInt32(str);

            //lesson3
            string str3;
            int d, e;

            Console.WriteLine("Enter a number 1");
            str3 = Console.ReadLine();
            d = Convert.ToInt32(str3);

            Console.WriteLine("Enter a number 2");
            str3 = Console.ReadLine();
            e = Convert.ToInt32(str3);

            int res = d + e;
            Console.WriteLine("Sum of numbers " + res);
            */

            ////lesson4
            ////Console.WriteLine("enter float number") ;
            ////string y = Console.ReadLine();
            //string y = "1.9";
            //Console.WriteLine(y.GetType());
            //Console.WriteLine(y);

            ////NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            ////{
            ////    NumberDecimalSeparator = ",",
            ////};
            ////double x = Convert.ToDouble(y,  numberFormatInfo);
            //double x = Convert.ToDouble(y);
            //Console.WriteLine(x.GetType());
            //Console.WriteLine(x);

            //lesson7 parse tryparse

            string str = "5";
            int a = int.Parse(str);


        }
    }
}
