using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
28. Write a C# program to reverse the words of a sentence.
Sample Output:
Original String: Display the pattern like pyramid using the alphabet.
Reverse String: alphabet. the using pyramid like pattern the Display
 */

namespace Exercise28
{

    class Exercise28Program
    {
        static void Main(string[] args)
        {

            Way1(args);

            Way2();

            Way3();

        }

        public static void Way1(string[] args)
        {

            char[] separators = { ' ' };

            Console.WriteLine("{0}",
                System.Reflection.MethodBase.GetCurrentMethod().Name);

            var str = args[0];

            var words = str.Split(separators);

            var newstr = "";

            for(int i = words.Length - 1; i >= 0; i--)
            {
                newstr += words[i] + " ";
            }

            Console.WriteLine("Original string: {0}\nResult string: {1}", str, newstr);

        }

        public static void Way2()
        {

            char[] separators = { ' ' };

            Console.WriteLine("{0}",
                System.Reflection.MethodBase.GetCurrentMethod().Name);

            Console.Write("Enter a string:");

            var str = Console.ReadLine();

            var words = str.Split(separators);

            var newstr = "";

            for (int i = words.Length - 1; i >= 0; i--)
            {
                newstr += words[i] + " ";
            }

            Console.WriteLine("Original string: {0}\nResult string: {1}", str, newstr);

        }

        public static void Way3()
        {

            char[] separators = { ' ' };

            Console.WriteLine("{0}",
                System.Reflection.MethodBase.GetCurrentMethod().Name);

            Console.Write("Enter a string:");

            var str = Console.ReadLine();

            var words = str.Split(separators);

            Array.Sort(words, (string str1, string str2) =>
            {
                return Array.IndexOf(words, str2).CompareTo(Array.IndexOf(words, str1));
            });

            var newstr = string.Join(" ", words);

            Console.WriteLine("Original string: {0}\nResult string: {1}", str, newstr);

        }

    }
}
