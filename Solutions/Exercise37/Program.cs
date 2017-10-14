using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
37. Write a C# program to check if "HP" appears at second position in a string and returns the string without "HP". Go to the editor
Test Data: PHP Tutorial
Sample Output:
P Tutorial
 */

namespace Exercise37
{

    class Exercise37Program
    {
        static void Main(string[] args)
        {

            Way1(args);

            Way2();

            Way3();

            Way4();

            Way5();

        }

        public static void Way1(string[] args)
        {


            Console.WriteLine("{0}",
                System.Reflection.MethodBase.GetCurrentMethod().Name);

            var str = args[0];

            if (str.Length >= 3 && str[1] == 'H' && str[2] == 'P')
            {
                Console.WriteLine("{0}{1}", str[0], str.Substring(3, str.Length-3));
            }
            else
            {
                Console.WriteLine("{0}", str);
            }

        }

        public static void Way2()
        {
            Console.WriteLine("{0}",
                System.Reflection.MethodBase.GetCurrentMethod().Name);

            Console.WriteLine("Input a string");
            var str = Console.ReadLine();

            if (str.Length >= 3 && str[1] == 'H' && str[2] == 'P')
            {
                Console.WriteLine("{0}{1}", str[0], str.Substring(3, str.Length - 3));
            }
            else
            {
                Console.WriteLine("{0}", str);
            }

        }

        public static void Way3()
        {
            Console.WriteLine("{0}",
                System.Reflection.MethodBase.GetCurrentMethod().Name);

            Console.WriteLine("Input a string");
            var str = Console.ReadLine();

            if (str.Length >= 3 && str.Substring(1,2) == "HP")
            {
                Console.WriteLine("{0}{1}", str[0], str.Substring(3, str.Length - 3));
            }
            else
            {
                Console.WriteLine(str);
            }

        }

        public static void Way4()
        {
            Console.WriteLine("{0}",
                System.Reflection.MethodBase.GetCurrentMethod().Name);

            Console.WriteLine("Input a string");
            var str = Console.ReadLine();

            var res = str.Length >= 3 && str[1] == 'H' && str[2] == 'P' ? str[0] + str.Substring(3, str.Length - 3) : str;

            Console.WriteLine("{0}", res);

        }

        public static void Way5()
        {
            Console.WriteLine("{0}",
                System.Reflection.MethodBase.GetCurrentMethod().Name);

            Console.WriteLine("Input a string");
            var str = Console.ReadLine();

            var res = str.Length >= 3 && str.Substring(1, 2) == "HP" ? str[0] + str.Substring(3, str.Length - 3) : str;

            Console.WriteLine("{0}", res);

        }

    }
}
