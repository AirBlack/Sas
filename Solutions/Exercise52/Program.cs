using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
52. Write a C# program to create a new array of length containing the middle elements of three arrays (each length 3) of integers.
Test Data:
Array1: [1, 2, 5]
Array2: [0, 3, 8]
Array3: [-1, 0, 2]
New array: [2, 3, 0] 
 */

namespace Exercise52
{

    class Exercise52Program
    {

        static int[] array1 = { 1, 2, 5 };

        static int[] array2 = { 0, 3, 8 };

        static int[] array3 = { -1, 0, 2 };

        static void Main(string[] args)
        {

            Way1(args); 

            Way2();

        }

        public static void Way1(string[] args)
        {

            Console.WriteLine("{0}",
                System.Reflection.MethodBase.GetCurrentMethod().Name);

            var res = (int[])array1.Clone();

            res[0] = array1[1];

            res[1] = array2[1];

            res[2] = array3[1];

            Console.WriteLine("Result: [{0}]", string.Join(", ", res));

        }

        public static void Way2()
        {

            Console.WriteLine("{0}",
                System.Reflection.MethodBase.GetCurrentMethod().Name);

            var res = (int[])array1.Clone();

            for (int i = 0; i < res.Length; i++)
            {
                switch(i)
                {
                    case 0:
                        res[i] = array1[1];
                        break;
                    case 1:
                        res[i] = array2[1];
                        break;
                    case 2:
                        res[i] = array3[1];
                        break;
                }
            }

            Console.WriteLine("Result: [{0}]", string.Join(", ", res)); ;

        }

    }
}
