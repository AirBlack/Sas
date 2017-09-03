using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


/*
34. Write a C# program to check if a string starts with a specified word. Go to the editor
Note: Suppose the sentence starts with "Hello"
Sample Data: string1 = "Hello how are you?"
Result: Hello.
Sample Output:
Input a string : Hello how are you? 
True
 */

namespace Exercise34
{

    class Exercise34Program
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

            char[] separators = { ' ', ',', '.' };

            Console.WriteLine("{0}",
                System.Reflection.MethodBase.GetCurrentMethod().Name);

            var str = args[0];

            var wordtosearch = "hello";

            Console.WriteLine("Given string: {0}\nResulg: {1}", str, str.Length >= wordtosearch.Length && (str.Substring(0, wordtosearch.Length).ToLower() == wordtosearch) && separators.Contains(str[wordtosearch.Length]));

        }

        public static void Way2()
        {

            Console.WriteLine("{0}",
                System.Reflection.MethodBase.GetCurrentMethod().Name);

            Console.Write("Input a string: ");

            var str = Console.ReadLine();

            var wordtosearch = "hello";

            Console.WriteLine("Given string: {0}\nResulg: {1}", str, str.Length >= wordtosearch.Length && str.Substring(0, wordtosearch.Length).ToLower() == wordtosearch);

        }

        public static void Way3()
        {

            char[] separators = { ' ', ',', '.' };

            Console.WriteLine("{0}",
                System.Reflection.MethodBase.GetCurrentMethod().Name);

            Console.Write("Input a string: ");

            var str = Console.ReadLine();

            var wordtosearch = "hello";

            var arr = str.Split(separators);

            Console.WriteLine("Given string: {0}\nResulg: {1}", str, arr[0].ToLower() == wordtosearch);

        }

        public static void Way4()
        {

            char[] separators = { ' ', ',', '.' };

            Console.WriteLine("{0}",
                System.Reflection.MethodBase.GetCurrentMethod().Name);

            Console.Write("Input a string: ");

            var str = Console.ReadLine();

            var wordtosearch = "hello";

            var arr = str.Split(separators);

            var result = false;

            if (arr[0].ToLower() == wordtosearch)
            {
                result = true;
            }

            Console.WriteLine("Given string: {0}\nResulg: {1}", str, result);

        }

        public static void Way5()
        {

            char[] separators = { ' ' };

            string[] search = { "hello ", "hello.", "hello,", "hello" };

            Console.WriteLine("{0}",
                System.Reflection.MethodBase.GetCurrentMethod().Name);

            Console.Write("Input a string: ");

            var str = Console.ReadLine();

            var arr = str.Split(separators);

            var result = false;

            if (search.Contains(arr[0].ToLower()))
            {
                result = true;
            }

            Console.WriteLine("Given string: {0}\nResulg: {1}", str, result);

        }

    }
}
