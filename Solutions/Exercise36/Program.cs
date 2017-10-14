using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
36. Write a C# program to check if an integer (from the two given integers) is in the range -10 to 10. Go to the editor
Sample Output:
Input a first number: -5
Input a second number: 8 
True
 */

namespace Exercise36
{

    class Exercise36Program
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

            var int1 = int.Parse(args[0]);

            var int2 = int.Parse(args[1]);

            if ((int1 >= -10 && int1 <= 10) || (int2 >= -10 && int2 <= 10))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

        }

        public static void Way2()
        {
            Console.WriteLine("{0}",
                System.Reflection.MethodBase.GetCurrentMethod().Name);

            Console.WriteLine("Input the first integer: ");
            var int1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Input the second integer: ");
            var int2 = int.Parse(Console.ReadLine());

            if ((int1 >= -10 && int1 <= 10) || (int2 >= -10 && int2 <= 10))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

        }

        public static void Way3()
        {
            Console.WriteLine("{0}",
                System.Reflection.MethodBase.GetCurrentMethod().Name);

            Console.WriteLine("Input the first integer: ");
            var int1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Input the second integer: ");
            var int2 = int.Parse(Console.ReadLine());

            var istrue = (int1 >= -10 && int1 <= 10) || (int2 >= -10 && int2 <= 10);

            Console.WriteLine(istrue.ToString());

        }

        public static void Way4()
        {
            Console.WriteLine("{0}",
                System.Reflection.MethodBase.GetCurrentMethod().Name);

            Console.WriteLine("Input the first integer: ");
            var int1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Input the second integer: ");
            var int2 = int.Parse(Console.ReadLine());

            var istrue = Enumerable.Range(-10, 21).Contains(int1) || Enumerable.Range(-10, 21).Contains(int2);

            Console.WriteLine(istrue.ToString());

        }

    }
}
