using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
19. Write a C# program to compute the sum of two given integers, if two values are equal then return the triple of their sum.
 */

namespace Exercise19
{
    class Exercise19Program
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

            int result = num1 == num2 ? (num1 + num2) * 3 : (num1 + num2);

            Console.WriteLine("{0}: \nGiven numbers: {1}, {2}. Result: {3}", 
                System.Reflection.MethodBase.GetCurrentMethod().Name, 
                num1, num2, result);

        }

        public static void Way2()
        {
            Console.Write("{0}: \nEnter first number: ",
               System.Reflection.MethodBase.GetCurrentMethod().Name);
            var num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            var num2 = int.Parse(Console.ReadLine());

            int result = num1 + num2;

            if(num1 == num2)
            {
                result *= 3;
            }

            Console.WriteLine("Given numbers: {0}, {1}. Result: {2}", num1, num2, result);
        }

        public static void Way3()
        {
            var num1 = 10;

            var num2 = 10;

            int result = num1 == num2 ? (num1 + num2) * 3 : (num1 + num2);

            Console.WriteLine("{0}: \nGiven numbers: {1}, {2}. Result: {3}",
                System.Reflection.MethodBase.GetCurrentMethod().Name,
                num1, num2, result);

        }
    }
}
