using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
41. Write a C# program to check if a given string contains ‘w’ character between 1 and 3 times. Go to the editor
Test Data:
Input a string (conatins at least one 'w' char) : w3resource 
Test the string contains 'w' character between 1 and 3 times:
Sample Output
True 
 */

namespace Exercise41
{

    class Exercise41Program
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

            var res = false;

            var count = 0;

            var found = str.IndexOf("w");

            while (found != -1)
            {
                count++;
                str = str.Substring(0, found) + str.Substring(found + 1, str.Length - 2 - found);
                found = str.IndexOf("w");
            }

            res = (count >=1 && count <= 3);

            Console.WriteLine("Result: {0}", res);

        }

        public static void Way2()
        {

            Console.WriteLine("{0}",
                System.Reflection.MethodBase.GetCurrentMethod().Name);

            Console.WriteLine("Input a string: ");
            var str = Console.ReadLine();

            var res = false;

            var count = 0;

            var found = str.IndexOf("w");

            while (found != -1)
            {
                count++;
                str = str.Substring(0, found) + str.Substring(found + 1, str.Length - 1 - found);
                found = str.IndexOf("w");
            }

            res = (count >= 1 && count <= 3);

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

            var found = str.IndexOf("w");

            while (found != -1)
            {
                count++;
                str = str.Substring(0, found) + str.Substring(found + 1, str.Length - 1 - found);
                found = str.IndexOf("w");
            }

            res = Enumerable.Range(1,3).Contains(count);

            Console.WriteLine("Result: {0}", res);

        }

        public static void Way4()
        {

            Console.WriteLine("{0}",
                System.Reflection.MethodBase.GetCurrentMethod().Name);

            Console.WriteLine("Input a string: ");
            var str = Console.ReadLine();

            var res = false;

            var count = 0;

            var found = str.IndexOf("w");

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'w')
                {
                    count++;
                }
            }

            res = (count >= 1 && count <= 3);

            Console.WriteLine("Result: {0}", res);

        }

        public static void Way5()
        {

            Console.WriteLine("{0}",
                System.Reflection.MethodBase.GetCurrentMethod().Name);

            Console.WriteLine("Input a string: ");
            var str = Console.ReadLine();

            var res = false;

            var count = 0;

            var found = str.IndexOf("w");

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'w')
                {
                    count++;
                }
            }

            res = Enumerable.Range(1, 3).Contains(count);

            Console.WriteLine("Result: {0}", res);

        }

    }
}
