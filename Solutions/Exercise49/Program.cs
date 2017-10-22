using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
49. Write a C# program to check if the first element or the last element of the two arrays ( length 1 or more) are equal. Go to the editor
Test Data:
Array1: [1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1] 
Array2: [1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 5]
Check if the first element or the last element of the two arrays ( leng th 1 or more) are equal. 
Sample Output
True 
 */

namespace Exercise49
{

    class Exercise49Program
    {

        static int[] array1 = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };

        static int[] array2 = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 5 };

        static void Main(string[] args)
        {

            Way1(args); 

            Way2();

        }

        public static void Way1(string[] args)
        {

            Console.WriteLine("{0}",
                System.Reflection.MethodBase.GetCurrentMethod().Name);

            var res = array1[0] == array2[0] || array1[array1.Length-1] == array2[array2.Length-1];

            Console.WriteLine("Result: {0}", res);

        }

        public static void Way2()
        {

            Console.WriteLine("{0}",
                System.Reflection.MethodBase.GetCurrentMethod().Name);

            var res = array1.First() == array2.First() || array1.Last() == array2.Last();

            Console.WriteLine("Result: {0}", res);

        }

    }
}
