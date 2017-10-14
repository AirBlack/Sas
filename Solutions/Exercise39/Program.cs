using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
39. Write a C# program to find the largest and lowest values from three integer values. Go to the editor
Test Data:
Input first integer:
15 
Input second integer:
25 
Input third integer: 
30
Sample Output
Largest of three: 30 
Lowest of three: 15
 */

namespace Exercise39
{

    class Exercise39Program
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

            var int3 = int.Parse(args[2]);

            var res1 = Math.Min(Math.Min(int1,int2), int3);

            var res2 = Math.Max(Math.Max(int1, int2), int3);

            Console.WriteLine("Lowest value: {0}\nLargest value: {1}", res1, res2);

        }

        public static void Way2()
        {

            Console.WriteLine("{0}",
                System.Reflection.MethodBase.GetCurrentMethod().Name);

            Console.WriteLine("Input the first number: ");
            var int1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Input the second number: ");
            var int2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Input the third number: ");
            var int3 = int.Parse(Console.ReadLine());

            var res1 = Math.Min(Math.Min(int1, int2), int3);

            var res2 = Math.Max(Math.Max(int1, int2), int3);

            Console.WriteLine("Lowest value: {0}\nLargest value: {1}", res1, res2);

        }

        public static void Way3()
        {
            Console.WriteLine("{0}",
                System.Reflection.MethodBase.GetCurrentMethod().Name);

            Console.WriteLine("Input the first number: ");
            var int1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Input the second number: ");
            var int2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Input the third number: ");
            var int3 = int.Parse(Console.ReadLine());

            var res1 = int1;

            if (int2 < res1)
            {
                res1 = int2;
            }
            if (int3 < res1)
            {
                res1 = int3;
            }
            //My programming practice teacher teached me to do this(actually with arrays and in pure c)

            var res2 = int1;

            if (int2 > res2)
            {
                res2 = int2;
            }
            if (int3 > res2)
            {
                res2 = int3;
            }

            Console.WriteLine("Lowest value: {0}\nLargest value: {1}", res1, res2);

        }

    }
}
