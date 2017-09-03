using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
23. Write a C# program to convert a given string into lowercase. Go to the editor
Sample Output:
write a c# sharp program to display the following pattern using the alphabet.
 */

namespace Exercise23
{
    class Exercise23Program
    {
        static void Main(string[] args)
        {

            Way1(args);

            Way2();

            Way3();

        }

        public static void Way1(string[] args)
        {
            var str = args[0];

            var result = str.ToLower();

            Console.WriteLine("{0}: \nGiven string: {1}. Result: {2}",
                System.Reflection.MethodBase.GetCurrentMethod().Name,str, result);

        }

        public static void Way2()
        {
            Console.Write("{0}: \nEnter any text: ",
               System.Reflection.MethodBase.GetCurrentMethod().Name);

            var str = Console.ReadLine();

            var result = str.ToLower();

            Console.WriteLine("Given string: {0}. Result: {1}", str, result);
        }

        public static void Way3()
        {
            Console.Write("{0}: \nEnter any text: ",
                System.Reflection.MethodBase.GetCurrentMethod().Name);

            var str = Console.ReadLine();

            var result = str;

            for(int i=0;i< result.Length;i++)
            {
                var stored = result[i];
                if (Char.IsUpper(stored))
                {
                    result = result.Remove(i, 1);
                    result = result.Insert(i, char.ToLower(stored).ToString());
                }
            }

            Console.WriteLine("Given string: {0}. Result: {1}", str, result);
        }

    }
}
