using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
43. Write a C# program to check if a given string starts with "w" and immediately followed by two "ww". Go to the editor
Test Data:
Input a string : www 
Sample Output
False 
 */

namespace Exercise43
{

    class Exercise43Program
    {
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

            var str = args[0];

            var res = str.Length >= 5 && str.Substring(0, 5) == "wwwww"; 

            Console.WriteLine("Result: {0}", res);

        }

        public static void Way2()
        {

            Console.WriteLine("{0}",
                 System.Reflection.MethodBase.GetCurrentMethod().Name);

            Console.WriteLine("Input a string: ");
            var str = Console.ReadLine();

            var res = str.Length >= 5 && str.Substring(0, 5) == "wwwww";

            Console.WriteLine("Result: {0}", res);

        }

        public static void Way3()
        {

            Console.WriteLine("{0}",
                 System.Reflection.MethodBase.GetCurrentMethod().Name);

            Console.WriteLine("Input a string: ");
            var str = Console.ReadLine();

            var res = false;

            var count = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'w')
                {
                    count++;
                }
                else
                {
                    count = 0;
                    break;
                }
            }

            if (count >= 5)
            {
                res = true;
            }

            Console.WriteLine("Result: {0}", res);

        }

    }
}
