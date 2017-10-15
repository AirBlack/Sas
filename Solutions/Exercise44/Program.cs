using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
44. Write a C# program to create a new string of every other character (odd position) from the first position of a given string. Go to the editor
Test Data:
Input a string : w3resource 
Sample Output
wrsuc 
 */

namespace Exercise44
{

    class Exercise44Program
    {
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

            var str = args[0];

            var res = "";

            for (int i = 0; i < str.Length; i++)
            {
                if (i % 2 == 0)//cos array starts from 0
                {
                    res += str[i];
                }
            }

            Console.WriteLine("Result: {0}", res);

        }

        public static void Way2()
        {

            Console.WriteLine("{0}",
                System.Reflection.MethodBase.GetCurrentMethod().Name);

            Console.WriteLine("Input a string: ");
            var str = Console.ReadLine();

            var res = "";

            for (int i = 0; i < str.Length; i++)
            {
                if (i % 2 == 0)//cos array starts from 0
                {
                    res += str[i];
                }
            }

            Console.WriteLine("Result: {0}", res);

        }

        public static void Way3()
        {

            Console.WriteLine("{0}",
                System.Reflection.MethodBase.GetCurrentMethod().Name);

            Console.WriteLine("Input a string: ");
            var str = Console.ReadLine();

            var res = "";

            for (int i = 0; i < str.Length; i+=2)
            {
                res += str[i];
            }

            Console.WriteLine("Result: {0}", res);

        }

        public static void Way4()
        {

            Console.WriteLine("{0}",
                System.Reflection.MethodBase.GetCurrentMethod().Name);

            Console.WriteLine("Input a string: ");
            var str = Console.ReadLine();

            var res = "";

            for (int i = 0; i < str.Length/2+1; i++)
            {
                if (str.Length > i * 2)
                {
                    res += str[i * 2];
                }
            }

            Console.WriteLine("Result: {0}", res);

        }

    }
}
