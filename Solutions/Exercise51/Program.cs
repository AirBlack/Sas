using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
51. Write a C# program to get the larger value between first and last element of an array (length 3) of integers.
Test Data:
Array1: [1, 2, 5, 7, 8] 
Highest value between first and last values of the said array: 8 
 */

namespace Exercise51
{

    class Exercise51Program
    {

        static int[] givenArray = { 1, 2, 5, 7, 8 };

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

            var res = Math.Max(givenArray[0], givenArray[givenArray.Length-1]);

            Console.WriteLine("Result: {0}", res);

        }

        public static void Way2()
        {

            Console.WriteLine("{0}",
                System.Reflection.MethodBase.GetCurrentMethod().Name);

            var res = Math.Max(givenArray.First(), givenArray.Last());

            Console.WriteLine("Result: {0}", res);

        }

        public static void Way3()
        {

            Console.WriteLine("{0}",
                System.Reflection.MethodBase.GetCurrentMethod().Name);

            var res = givenArray[0];

            if (givenArray[givenArray.Length - 1] > res)
            {
                res = givenArray[givenArray.Length - 1];
            }

            Console.WriteLine("Result: {0}", res);

        }

        public static void Way4()
        {

            Console.WriteLine("{0}",
                System.Reflection.MethodBase.GetCurrentMethod().Name);

            var res = givenArray.First();

            if (givenArray.Last() > res)
            {
                res = givenArray.Last();
            }

            Console.WriteLine("Result: {0}", res);

        }

    }
}
