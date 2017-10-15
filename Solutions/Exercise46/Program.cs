using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
46. Write a C# program to check if a number appears as either the first or last element of an array of integers and the length is 1 or more. Go to the editor
Test Data:
Input an integer: 25 
Sample Output
False 
 */

namespace Exercise46
{

    class Exercise46Program
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

            var res = givenArray[0] == num || givenArray.Last() == num;

            Console.WriteLine("Result: {0}", res);

        }

        public static void Way2()
        {

            Console.WriteLine("{0}",
                System.Reflection.MethodBase.GetCurrentMethod().Name);

            Console.WriteLine("Input a number: ");
            var num = int.Parse(Console.ReadLine());

            var res = givenArray[0] == num || givenArray.Last() == num;

            Console.WriteLine("Result: {0}", res);

        }

        public static void Way3()
        {

            Console.WriteLine("{0}",
                System.Reflection.MethodBase.GetCurrentMethod().Name);

            Console.WriteLine("Input a number: ");
            var num = int.Parse(Console.ReadLine());

            var res = givenArray[0] == num || givenArray[givenArray.Length-1] == num;

            Console.WriteLine("Result: {0}", res);

        }

    }
}
