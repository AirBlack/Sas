using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


/*
30. Write a C# program to convert a decimal number to hexadecimal number.
Sample Output:
Hexadecimal number: 4B0
Convert to- 
Decimal number: 1200 
 */

namespace Exercise30
{

    class Exercise30Program
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

            var num = int.Parse(args[0]);

            var hex = num.ToString("X");

            Console.WriteLine("Decimal: {0}\nHex: {1}", num, hex);

        }

        public static void Way2()
        {

            Console.WriteLine("{0}",
                System.Reflection.MethodBase.GetCurrentMethod().Name);

            Console.Write("Enter a decimal number: ");

            var num = int.Parse(Console.ReadLine());

            var hex = num.ToString("X");

            Console.WriteLine("Decimal: {0}\nHex: {1}", num, hex);

        }

        public static void Way3()
        {

            Console.WriteLine("{0}",
                System.Reflection.MethodBase.GetCurrentMethod().Name);

            Console.Write("Enter a decimal number: ");

            var num = int.Parse(Console.ReadLine());

            var hex = String.Format("0x{0:X}", num);

            Console.WriteLine("Decimal: {0}\nHex: {1:X}", num, num);

        }

    }
}
