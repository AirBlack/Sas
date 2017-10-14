using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
38. Write a C# program to get a new string of two characters from a given string. The first and second character of the given string must be "P" and "H", so PHP will be "PH". Go to the editor
Test Data: PHP
Sample Output:
PH
 */

namespace Exercise38
{

    class Exercise38Program
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

            if (str.Length >= 1 && str[0] == 'P')
            {
                res += 'P';
                if (str.Length >= 2 && str[1] == 'H')
                    res += 'H';
                Console.WriteLine("{0}", res);
            }

        }

        public static void Way2()
        {
            Console.WriteLine("{0}",
                 System.Reflection.MethodBase.GetCurrentMethod().Name);

            Console.WriteLine("Input a string: ");
            var str = Console.ReadLine();

            var res = "";

            if (str.Length >= 1 && str[0] == 'P')
            {
                res += 'P';
                if (str.Length >= 2 && str[1] == 'H')
                    res += 'H';
                Console.WriteLine("{0}", res);
            }

        }

        public static void Way3()
        {
            Console.WriteLine("{0}",
                 System.Reflection.MethodBase.GetCurrentMethod().Name);

            Console.WriteLine("Input a string: ");
            var str = Console.ReadLine();

            var res = "";

            if (str.Length >= 1)
            {
                if (str.Length >= 2)
                {
                    res = str.Substring(0, 2) == "PH" ? "PH" : "";
                }
                else
                {
                    res = str[0] == 'P' ? "P" : "";
                }
                if (res != "")
                {
                    Console.WriteLine("{0}", res);
                }
            }

        }

        public static void Way4()
        {
            Console.WriteLine("{0}",
                 System.Reflection.MethodBase.GetCurrentMethod().Name);

            Console.WriteLine("Input a string: ");
            var str = Console.ReadLine();

            var res = "";

            if (str.Length >= 1)
            {
                if (str.Length >= 2)
                {
                    res = str.StartsWith("PH") ? "PH" : "";
                }
                else
                {
                    res = str.StartsWith("P") ? "P" : "";
                }
                if (res != "")
                {
                    Console.WriteLine("{0}", res);
                }
            }

        }

    }
}
