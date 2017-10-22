using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
50. Write a C# program to rotate an array (length 3) of integers in left direction. Go to the editor
Test Data:
Array1: [1, 2, 8]
After rotating array becomes: [2, 8, 1] 
 */

namespace Exercise50
{

    class Exercise50Program
    {

        static int[] givenArray = { 1, 2, 8 };

        static void Main(string[] args)
        {

            Way1(args); 

            Way2();

        }

        public static void Way1(string[] args)
        {

            Console.WriteLine("{0}",
                System.Reflection.MethodBase.GetCurrentMethod().Name);

            var res = (int[])givenArray.Clone();

            //that works only if length is 3(that means that it's not universal)

            res[0] = givenArray.Last();
            res[res.Length - 1] = givenArray.First();

          

            Console.WriteLine("Result: [{0}]", string.Join(", ", res));

        }

        public static void Way2()
        {

            Console.WriteLine("{0}",
                System.Reflection.MethodBase.GetCurrentMethod().Name);

            var res = (int[])givenArray.Clone();

            for (int i = 0; i < givenArray.Length; i++)
            {
                res[i] = givenArray[givenArray.Length - 1 - i];
            }

            Console.WriteLine("Result: [{0}]", string.Join(", ", res));

        }

    }
}
