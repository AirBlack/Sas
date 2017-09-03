using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
24. Write a C# program to find the longest word in a string.
Test Data: Write a C# Sharp Program to display the following pattern using the alphabet.
Sample Output:
following
 */

namespace Exercise24
{

    class Exercise24Program
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
            char[] separators = { ' ', ',', '.' };

            var str = args[0];

            var words = str.Split(separators);

            var result = "";

            foreach(string word in words)
            {
                if(word.Length > result.Length)
                {
                    result = word;
                }
            }

            Console.WriteLine("{0}: \nGiven string: {1}. Result: {2}",
                System.Reflection.MethodBase.GetCurrentMethod().Name,str, result);

        }

        public static void Way2()
        {
            char[] separators = { ' ', ',', '.' };

            Console.Write("{0}: \nEnter any text: ",
               System.Reflection.MethodBase.GetCurrentMethod().Name);

            var str = Console.ReadLine();

            var words = str.Split(separators);

            var result = "";

            foreach (string word in words)
            {
                if (word.Length > result.Length)
                {
                    result = word;
                }
            }

            Console.WriteLine("Given string: {0}. Result: {1}", str, result);
        }

        public static void Way3()
        {
            char[] separators = { ' ', ',', '.' };

            Console.Write("{0}: \nEnter any text: ",
               System.Reflection.MethodBase.GetCurrentMethod().Name);

            var str = Console.ReadLine();

            var words = str.Split(separators);

            var result = "";

            for(int i = 0; i<words.Length;i++)
            {
                if(words[i].Length > result.Length)
                {
                    result = words[i];
                }
            }

            Console.WriteLine("Given string: {0}. Result: {1}", str, result);
        }

        public static void Way4()
        {
            char[] separators = { ' ', ',', '.' };

            Console.Write("{0}: \nEnter any text: ",
               System.Reflection.MethodBase.GetCurrentMethod().Name);

            var str = Console.ReadLine();

            var words = str.Split(separators);

            var result = "";

            words.ToList().ForEach(delegate(string word)
            {
                if(word.Length > result.Length)
                {
                    result = word;
                }
            });

            Console.WriteLine("Given string: {0}. Result: {1}", str, result);
        }

    }
}
