using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
48. Write a C# program to check if the first element and the last element are equal of an array of integers and the length is 1 or more. Go to the editor
Test Data:
Array1: [1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1] 
Sample Output
True 
 */

namespace Exercise48
{

    class Exercise48Program
    {

        static int[] givenArray = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };

        static void Main(string[] args)
        {

            Way1(args); 

            Way2();

        }

        public static void Way1(string[] args)
        {

            Console.WriteLine("{0}",
                System.Reflection.MethodBase.GetCurrentMethod().Name);

            var res = givenArray.Length >= 1 && givenArray[0] == givenArray[givenArray.Length-1];

            Console.WriteLine("Result: {0}", res);

        }

        public static void Way2()
        {

            Console.WriteLine("{0}",
                System.Reflection.MethodBase.GetCurrentMethod().Name);

            var res = givenArray.Length >= 1 && givenArray.First() == givenArray.Last();

            Console.WriteLine("Result: {0}", res);

        }

    }
}
