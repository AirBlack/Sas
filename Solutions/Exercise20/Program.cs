using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
20. Write a C# program to get the absolute value of the difference between two given numbers. Return double the absolute value of the difference if the first number is greater than second number.
 */

namespace Exercise20
{
    class Exercise20Program
    {
        static void Main(string[] args)
        {
            
            Way1(args);

            Way2();

            Way3();
			
			Way4();
			
			Way5();
            
        }

        public static void Way1(string[] args)
        {
            int num1 = int.Parse(args[0]);
            int num2 = int.Parse(args[1]);

            int diff = Math.Abs(num1 - num2);
            int result = num1 > num2 ? (diff * 2) : diff;

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

            int diff = num1 - num2;

            if(diff < 0)
            {
                diff = -diff;
            }

            if(num1 > num2)
            {
                diff *= 2;
            }

            Console.WriteLine("Given numbers: {0}, {1}. Result: {2}", num1, num2, diff);
        }

        public static void Way3()
        {
            Console.Write("{0}: \nEnter first number: ",
               System.Reflection.MethodBase.GetCurrentMethod().Name);
            var num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            var num2 = int.Parse(Console.ReadLine());

            int diff = Math.Abs(num1 - num2);

            int result = num1 > num2 ? (diff * 2) : diff;

            Console.WriteLine("Given numbers: {0}, {1}. Result: {2}",
                num1, num2, result);

        }
		
		public static void Way4()
        {
            Console.Write("{0}: \nEnter first number: ",
               System.Reflection.MethodBase.GetCurrentMethod().Name);
            var num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            var num2 = int.Parse(Console.ReadLine());

            int result = num1 > num2 ? ((num1-num2) * 2) : (num2-num1);

            Console.WriteLine("Given numbers: {0}, {1}. Result: {2}",
                num1, num2, result);

        }
		
		public static void Way5()
        {
            Console.Write("{0}: \nEnter first number: ",
               System.Reflection.MethodBase.GetCurrentMethod().Name);
            var num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            var num2 = int.Parse(Console.ReadLine());

            int diff = num1 - num2;
			
			if(diff < 0)
			{
				diff = -diff;
			}

            int result = num1 > num2 ? (diff * 2) : diff;

            Console.WriteLine("Given numbers: {0}, {1}. Result: {2}",
                num1, num2, result);

        }
    }
}
