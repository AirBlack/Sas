using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
22. Write a C# program to check if an given integer is within 20 of 100 or 200.
Sample Output:
Input an integer: 
25 
False 
 */

namespace Exercise22
{
    class Exercise22rogram
    {
        static void Main(string[] args)
        {

            Way1(args);

            Way2();

            Way3();

            Way4();

            Way5();

            Way6();

            Way7();

        }

        public static void Way1(string[] args)
        {
            int num1 = int.Parse(args[0]);

            var result = Enumerable.Range(100,21).Contains(num1) || Enumerable.Range(200, 21).Contains(num1);

            Console.WriteLine("{0}: \nGiven number: {1}. Result: {2}",
                System.Reflection.MethodBase.GetCurrentMethod().Name,
                num1, result.ToString());

        }

        public static void Way2()
        {
            Console.Write("{0}: \nEnter first number: ",
               System.Reflection.MethodBase.GetCurrentMethod().Name);
            var num1 = int.Parse(Console.ReadLine());

            var result = false;

            if (Enumerable.Range(100, 21).Contains(num1) || Enumerable.Range(200, 21).Contains(num1))
            {
                result = true;
            }

            Console.WriteLine("Given number: {0}. Result: {1}", num1, result);
        }

        public static void Way3()
        {
            Console.Write("{0}: \nEnter first number: ",
               System.Reflection.MethodBase.GetCurrentMethod().Name);
            var num1 = int.Parse(Console.ReadLine());

            var result = false;

            if (((num1>=100) && (num1 <= 120)) || ((num1>=200) && (num1 <= 220)))
            {
                result = true;
            }

            Console.WriteLine("Given number: {0}. Result: {1}", num1, result);

        }

        public static void Way4()
        {
            Console.Write("{0}: \nEnter first number: ",
                System.Reflection.MethodBase.GetCurrentMethod().Name);
            var num1 = int.Parse(Console.ReadLine());

            var result = false;

            if ((Math.Abs(num1-100) <= 20) || (Math.Abs(num1-200) <= 20))
            {
                result = true;
            }

            Console.WriteLine("Given number: {0}. Result: {1}", num1, result);

        }

        public static void Way5()
        {
            Console.Write("{0}: \nEnter first number: ",
                System.Reflection.MethodBase.GetCurrentMethod().Name);
            var num1 = int.Parse(Console.ReadLine());

            var result = false;

            var numstring = num1.ToString();

            if (numstring.Length == 3 && (numstring[0] == '1' || numstring[0] == '2') && (numstring[1] == '0' || numstring[1] == '1' || numstring[1] == '2'))
            {
                result = true;
            }

            Console.WriteLine("Given number: {0}. Result: {1}", num1, result);

        }

        public static void Way6()
        {
            Console.Write("{0}: \nEnter first number: ",
                System.Reflection.MethodBase.GetCurrentMethod().Name);
            var num1 = int.Parse(Console.ReadLine());

            var result = false;

            var numstring = num1.ToString();

            if (numstring.Length == 3 && (Enumerable.Range(1,2).Contains(int.Parse(numstring[0].ToString()))) && (Enumerable.Range(0, 3).Contains(int.Parse(numstring[1].ToString()))))
            {
                result = true;
            }

            Console.WriteLine("Given number: {0}. Result: {1}", num1, result);

        }

        public static void Way7()
        {
            Console.Write("{0}: \nEnter first number: ",
                System.Reflection.MethodBase.GetCurrentMethod().Name);
            var num1 = int.Parse(Console.ReadLine());

            var result = false;

            var numstring = num1.ToString();

            var hundreds = int.Parse(numstring[0].ToString());
            var tens = int.Parse(numstring[1].ToString());

            if (numstring.Length == 3 && (hundreds >= 1 && hundreds <= 2) && (tens >= 0 && tens <= 2))
            {
                result = true;
            }

            Console.WriteLine("Given number: {0}. Result: {1}", num1, result);

        }

    }
}
