using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
18. Write a C# program to check two given integers and return true if one is negative and one is positive.
Sample Output:
Input first integer:
-5 
Input second integer: 
25 
Check if one is negative and one is positive: 
True 
 */

namespace Exercise18
{
    class Exercise18Program
    {
        static void Main(string[] args)
        {
            
            Way1(args);

            Way2();

            Way3();
            
        }

        public static void Way1(string[] args)
        {
            int num1 = int.Parse(args[0]);
            int num2 = int.Parse(args[1]);
            bool isnegativeandshit = (num1 < 0) ^ (num2 < 0);
            Console.WriteLine("{0}: \nGiven numbers: {1}, {2}. Is one of it negative and the other one positive: {3}", 
                System.Reflection.MethodBase.GetCurrentMethod().Name, 
                num1, num2, isnegativeandshit.ToString());

        }

        public static void Way2()
        {
            Console.Write("{0}: \nEnter first number: ",
               System.Reflection.MethodBase.GetCurrentMethod().Name);
            var num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            var num2 = int.Parse(Console.ReadLine());

            bool isnegativeandshit = (num1< 0) ^ (num2 < 0);

            Console.WriteLine("Given numbers: {0}, {1}. Is one of it negative and the other one positive: {2}", num1, num2, isnegativeandshit.ToString());
        }

        public static void Way3()
        {
            Console.Write("{0}: \nEnter first number: ",
               System.Reflection.MethodBase.GetCurrentMethod().Name);
            var num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            var num2 = int.Parse(Console.ReadLine());

            bool isnegativeandshit = (num1 < 0 && num2 >= 0) || (num1 >= 0 && num2 < 0);

            Console.WriteLine("Given numbers: {0}, {1}. Is one of it negative and the other one positive: {2}", num1, num2, isnegativeandshit.ToString());

        }
    }
}
