using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
47. Write a C# program to compute the sum of all the elements of an array of integers. Go to the editor
Test Data:
Array1: [1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1] 
Sample Output
Sum: 69 
 */

namespace Exercise47
{

    class Exercise47Program
    {

        static int[] givenArray = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };

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

            var res = givenArray.Sum();

            Console.WriteLine("Result: {0}", res);

        }

        public static void Way2()
        {

            Console.WriteLine("{0}",
                System.Reflection.MethodBase.GetCurrentMethod().Name);

            var res = 0;

            for (int i = 0; i < givenArray.Length; i++)
            {
                res += givenArray[i];
            }

            Console.WriteLine("Result: {0}", res);

        }

        public static void Way3()
        {

            Console.WriteLine("{0}",
                System.Reflection.MethodBase.GetCurrentMethod().Name);

            var res = 0;

            foreach(int num in givenArray)
            {
                res += num;
            }

            Console.WriteLine("Result: {0}", res);

        }

    }
}
