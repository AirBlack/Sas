using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


/*
33. Write a C# program to check if a given positive number is a multiple of 3 or a multiple of 7. Go to the editor
Sample Output:
Input first integer:
15 
True
 */

namespace Exercise33
{

    class Exercise33Program
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

            var num = int.Parse(args[0]);

            Console.WriteLine("Given number: {0}\n{1}", num, (num >= 0 && ((num % 3 == 0) || (num % 7 == 0))).ToString());

        }

        public static void Way2()
        {

            Console.WriteLine("{0}",
                System.Reflection.MethodBase.GetCurrentMethod().Name);

            Console.Write("Input a number:");

            var num = int.Parse(Console.ReadLine());

            Console.WriteLine("Given number: {0}\n{1}", num, (num >= 0 && ((num % 3 == 0) || (num % 7 == 0))).ToString());

        }

        public static void Way3()
        {

            Console.WriteLine("{0}",
                System.Reflection.MethodBase.GetCurrentMethod().Name);

            Console.Write("Input a number:");

            var num = int.Parse(Console.ReadLine());

            var sas = (num >= 0 && ((num % 3 == 0) || (num % 7 == 0))) ? "True" : "False";

            Console.WriteLine("Given number: {0}\n{1}", num, sas);

        }

        public static void Way4()
        {

            Console.WriteLine("{0}",
                System.Reflection.MethodBase.GetCurrentMethod().Name);

            Console.Write("Input a number:");

            var num = int.Parse(Console.ReadLine());

            var sas = "False";

            if(num >= 0)
            {
                if(num % 3 == 0 || num % 7 == 0)
                {
                    sas = "True";
                }
            }

            Console.WriteLine("Given number: {0}\n{1}", num, sas);

        }

    }
}
