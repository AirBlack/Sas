using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
40. Write a C# program to check the nearest value of 20 of two given integers and return 0 if two numbers are same. Go to the editor
Test Data:
Input first integer:
15 
Input second integer:
12 
Sample Output
15
 */

namespace Exercise40
{

    class Exercise40Program
    {
        static void Main(string[] args)
        {

            Way1(args);

            Way2();

            Way3();

        }

        public static void Way1(string[] args)
        {

            Console.WriteLine("{0}",
                System.Reflection.MethodBase.GetCurrentMethod().Name);

            var int1 = int.Parse(args[0]);

            var int2 = int.Parse(args[1]);

            var res = int1 == int2 ? 0 : Math.Abs(20 - int1) < Math.Abs(20 - int2) ? int1 : int2;

            Console.WriteLine("{0}", res);

        }

        public static void Way2()
        {

            Console.WriteLine("{0}",
                System.Reflection.MethodBase.GetCurrentMethod().Name);

            Console.WriteLine("Input the first number: ");
            var int1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Input the second number");
            var int2 = int.Parse(Console.ReadLine());

            var res = int1 == int2 ? 0 : Math.Abs(20 - int1) < Math.Abs(20 - int2) ? int1 : int2;

            Console.WriteLine("{0}", res);

        }

        public static void Way3()
        {

            Console.WriteLine("{0}",
                System.Reflection.MethodBase.GetCurrentMethod().Name);

            Console.WriteLine("Input the first number: ");
            var int1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Input the second number");
            var int2 = int.Parse(Console.ReadLine());

            var res = 0;

            if (int1 != int2)
            {
                res = int1;
                if (Math.Abs(20-int1) > Math.Abs(20-int2))
                {
                    res = int2;
                }
            }

            Console.WriteLine("{0}", res);

        }

    }
}
