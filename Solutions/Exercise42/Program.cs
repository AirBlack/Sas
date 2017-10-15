using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
42. Write a C# program to create a new string where the first 4 characters will be in lower case. If the string is less than 4 characters then make the whole string in upper case. Go to the editor
Test Data:
Input a string: w3r 
Sample Output
W3R 
 */

namespace Exercise42
{

    class Exercise42Program
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

            var res = str;

            if (str.Length >= 4)
            {
                res = res.Substring(0, 4).ToLower() + res.Substring(4, res.Length - 4);
            }
            else
            {
                res = res.ToUpper();
            }

            Console.WriteLine("Result: {0}", res);

        }

        public static void Way2()
        {

            Console.WriteLine("{0}",
                            System.Reflection.MethodBase.GetCurrentMethod().Name);

            Console.WriteLine("Input a string: ");
            var str = Console.ReadLine();

            var res = str;

            if (str.Length >= 4)
            {
                res = res.Substring(0, 4).ToLower() + res.Substring(4, res.Length - 4);
            }
            else
            {
                res = res.ToUpper();
            }

            Console.WriteLine("Result: {0}", res);

        }

        public static void Way3()
        {

            Console.WriteLine("{0}",
                            System.Reflection.MethodBase.GetCurrentMethod().Name);

            Console.WriteLine("Input a string: ");
            var str = Console.ReadLine();

            var res = str.ToCharArray();

            for (int i = 0; i < res.Length; i++)
            {
                if (res.Length >= 4)
                {
                    if (i < 4)
                    {
                        res[i] = Char.ToLower(res[i]);
                    }
                }
                else
                {
                    res[i] = Char.ToUpper(res[i]);
                }
            }

            var finalres = new string(res);

            Console.WriteLine("Result: {0}", finalres);

        }

    }
}
