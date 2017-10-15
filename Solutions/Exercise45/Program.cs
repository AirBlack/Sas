using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
45. Write a C# program to count a specified number in a given array of integers. Go to the editor
Test Data:
Input an integer: 5 
Sample Output
Number of 5 present in the said array: 2 
 */

namespace Exercise45
{

    class Exercise45Program
    {

        static int[] givenArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 2, 2, 2, 4, 4 };

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

            var num = int.Parse(args[0]);

            var count = 0;

            for (int i = 0; i < givenArray.Length; i++)
            {
                if (givenArray[i] == num)
                {
                    count++;
                }
            }

            Console.WriteLine("Result: {0}", count);

        }

        public static void Way2()
        {

            Console.WriteLine("{0}",
                System.Reflection.MethodBase.GetCurrentMethod().Name);

            Console.WriteLine("Write a number: ");
            var num = int.Parse(Console.ReadLine());

            var count = 0;

            for (int i = 0; i < givenArray.Length; i++)
            {
                if (givenArray[i] == num)
                {
                    count++;
                }
            }

            Console.WriteLine("Result: {0}", count);

        }

        public static void Way3()
        {

            Console.WriteLine("{0}",
                System.Reflection.MethodBase.GetCurrentMethod().Name);

            Console.WriteLine("Write a number: ");
            var num = int.Parse(Console.ReadLine());

            var count = 0;

            foreach(int i in givenArray)
            {
                if (i == num)
                {
                    count++;
                }
            }

            Console.WriteLine("Result: {0}", count);

        }

    }
}
