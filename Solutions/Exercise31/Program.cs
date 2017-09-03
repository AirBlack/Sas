using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


/*
31. Write a C# program to multiply corresponding elements of two arrays of integers.
Sample Output:
Array1: [1, 3, -5, 4]
Array2: [1, 4, -5, -2]
Multiply corresponding elements of two arrays:
1 12 25 -8
 */

namespace Exercise31
{

    class Exercise31Program
    {
        static void Main(string[] args)
        {

            Way1(args);

        }

        public static void Way1(string[] args)
        {

            Console.WriteLine("{0}",
                System.Reflection.MethodBase.GetCurrentMethod().Name);

            int[] array1 = { 1, 3, -5, 4 };

            int[] array2 = { 1, 4, -5, -2 };

            Console.WriteLine("Array1: [{0}]\nArray2: [{1}]\nMultiply corresponding elements of two arrays:", String.Join(", ", array1), String.Join(", ", array2));

            for(int i = 0; i < array1.Length; i++)
            {
                Console.Write("{0} ", array1[i] * array2[i]);
            }
            Console.Write("\n");
        }

    }
}
