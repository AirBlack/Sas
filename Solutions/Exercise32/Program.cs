using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


/*
32. Write a C# program to create a new string of four copies, taking last four characters from a given string. If the length of the given string is less than 4 return the original one.
Sample Output:
Input a string : The quick brown fox jumps over the lazy dog.
dog.dog.dog.dog.
 */

namespace Exercise32
{

    class Exercise32Program
    {
        static void Main(string[] args)
        {

            Way1(args);

            Way2();

            Way3();

            Way4();

            Way5();

            Way6();

        }

        public static void Way1(string[] args)
        {

            Console.WriteLine("{0}",
                System.Reflection.MethodBase.GetCurrentMethod().Name);

            var str = args[0];

            Console.WriteLine("Original string: {0}", str);

            if(str.Length >= 4)
            {
                var siz = str.Length;
                string lastchars = str[siz-4].ToString() + str[siz-3].ToString() + str[siz-2].ToString() + str[siz-1].ToString();

                Console.WriteLine(lastchars + lastchars + lastchars + lastchars);
            }
            else
            {
                Console.WriteLine(str);
            }
        }

        public static void Way2()
        {

            Console.WriteLine("{0}",
                System.Reflection.MethodBase.GetCurrentMethod().Name);

            Console.Write("Input a string:");

            var str = Console.ReadLine();

            Console.WriteLine("Original string: {0}", str);

            if (str.Length >= 4)
            {
                var siz = str.Length;
                string lastchars = str[siz - 4].ToString() + str[siz - 3].ToString() + str[siz - 2].ToString() + str[siz - 1].ToString();

                Console.WriteLine(lastchars + lastchars + lastchars + lastchars);
            }
            else
            {
                Console.WriteLine(str);
            }
        }

        public static void Way3()
        {

            Console.WriteLine("{0}",
                System.Reflection.MethodBase.GetCurrentMethod().Name);

            Console.Write("Input a string:");

            var str = Console.ReadLine();

            Console.WriteLine("Original string: {0}", str);

            if (str.Length >= 4)
            {
                var siz = str.Length;


                string lastchars = str.Substring(siz-4,4);

                Console.WriteLine(lastchars + lastchars + lastchars + lastchars);
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

            Console.Write("Input a string:");

            var str = Console.ReadLine();

            Console.WriteLine("Original string: {0}", str);

            if (str.Length >= 4)
            {
                var siz = str.Length;


                string lastchars = str.Substring(siz - 4, 4);

                for(int i = 0; i < 4; i++)
                {
                    Console.Write(lastchars);
                }

                Console.Write("\n");

            }
            else
            {
                Console.WriteLine(str);
            }
        }

        public static void Way5()
        {

            Console.WriteLine("{0}",
                System.Reflection.MethodBase.GetCurrentMethod().Name);

            Console.Write("Input a string:");

            var str = Console.ReadLine();

            Console.WriteLine("Original string: {0}", str);

            if (str.Length >= 4)
            {
                var siz = str.Length;


                string lastchars = str.Substring(siz - 4, 4);

                var list = new List<string>();

                for (int i = 0; i < 4; i++)
                {
                    list.Add(lastchars);
                }

                list.ForEach(delegate(string strr)
                {
                    Console.Write(strr);
                });

                Console.Write("\n");

            }
            else
            {
                Console.WriteLine(str);
            }
        }

        public static void Way6()
        {

            Console.WriteLine("{0}",
                System.Reflection.MethodBase.GetCurrentMethod().Name);

            Console.Write("Input a string:");

            var str = Console.ReadLine();

            Console.WriteLine("Original string: {0}", str);

            if (str.Length >= 4)
            {
                var siz = str.Length;


                string lastchars = str.Substring(siz - 4, 4);

                var arr = new string[4];

                for (int i = 0; i < 4; i++)
                {
                    arr[i] = lastchars;
                }

                Console.WriteLine(String.Join("", arr));

            }
            else
            {
                Console.WriteLine(str);
            }
        }

    }
}
