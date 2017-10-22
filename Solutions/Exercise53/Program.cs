using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
53. Write a C# program to check if an array contains an odd number.
Test Data:
Original array: [2, 4, 7, 8, 6]
Check if an array contains an odd number? True 
 */

namespace Exercise53
{

    class Exercise53Program
    {

        static int[] givenArray = { 2, 4, 7, 8, 6 };

        static void Main(string[] args)
        {

            Way1(args); 

            Way2();

        }

        public static void Way1(string[] args)
        {

            Console.WriteLine("{0}",
                System.Reflection.MethodBase.GetCurrentMethod().Name);

            var res = false;

            for (int i = 0; i < givenArray.Length; i++)
            {
                if (givenArray[i] % 2 == 1)
                {
                    res = true;
                    break;
                }
            }

            Console.WriteLine("Result: {0}", res);

        }

        public static void Way2()
        {

            Console.WriteLine("{0}",
                System.Reflection.MethodBase.GetCurrentMethod().Name);

            var res = false;

            foreach(int i in givenArray)
            {
                if (i % 2 == 1)
                {
                    res = true;
                    break;
                }
            }

            Console.WriteLine("Result: {0}", res);

        }

    }
}
