using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


/*
35. Write a C# program to check two given numbers where one is less than 100 and other is greater than 200.
Sample Output:
Input a first number(<100): 75 
Input a second number(>100): 250
True
 */

namespace Exercise35
{

    class Exercise35Program
    {
        static void Main(string[] args)
        {

            Way1(args);

            Way2();

            Way3();

            Way4();

        }

        public static void Way1(string[] args)
        {

            Console.WriteLine("{0}",
                System.Reflection.MethodBase.GetCurrentMethod().Name);

            var num1 = int.Parse(args[0]);
            var num2 = int.Parse(args[1]);

            Console.WriteLine("Given numbers: {0}(<100), {1}(>200)", num1, num2);

            Console.WriteLine("Result: {0}", num1 < 100 && num2 > 200);

        }

        public static void Way2()
        {

            Console.WriteLine("{0}",
                System.Reflection.MethodBase.GetCurrentMethod().Name);

            Console.Write("Input the first number(<100): ");

            var num1 = int.Parse(Console.ReadLine());

            Console.Write("Input the second number(>200): ");
            var num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Result: {0}", num1 < 100 && num2 > 200);

        }

        public static void Way3()
        {

            Console.WriteLine("{0}",
                System.Reflection.MethodBase.GetCurrentMethod().Name);

            Console.Write("Input the first number(<100): ");

            var num1 = int.Parse(Console.ReadLine());

            Console.Write("Input the second number(>200): ");
            var num2 = int.Parse(Console.ReadLine());

            var result = num1 < 100 && num2 > 200 ? "True" : "False";

            Console.WriteLine("Result: {0}", result);

        }

        public static void Way4()
        {

            Console.WriteLine("{0}",
                System.Reflection.MethodBase.GetCurrentMethod().Name);

            Console.Write("Input the first number(<100): ");

            var num1 = int.Parse(Console.ReadLine());

            Console.Write("Input the second number(>200): ");
            var num2 = int.Parse(Console.ReadLine());

            var result = false;

            if(num1 < 100 && num2 > 200)
            {
                result = true;
            }

            Console.WriteLine("Result: {0}", result);

        }

    }
}
