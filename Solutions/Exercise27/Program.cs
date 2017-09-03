using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
27. Write a C# program and compute the sum of the digits of an integer.
Sample Output:
Input a number(integer): 12
Sum of the digits of the said integer: 3 
 */

namespace Exercise27
{

    class Exercise27Program
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

            var num = args[0];

            var sum = 0;
            
            foreach(char c in num.ToString())
            {
                sum += int.Parse(c.ToString());
            }

            Console.WriteLine("Sum of digits in number {0} is {1}", num, sum);

        }

        public static void Way2()
        {


            Console.WriteLine("{0}",
                System.Reflection.MethodBase.GetCurrentMethod().Name);

            Console.Write("Enter a number: ");

            var num = Console.ReadLine();

            var sum = 0;

            foreach (char c in num.ToString())
            {
                sum += int.Parse(c.ToString());
            }

            Console.WriteLine("Sum of digits in number {0} is {1}", num, sum);

        }

        public static void Way3()
        {


            Console.WriteLine("{0}",
                System.Reflection.MethodBase.GetCurrentMethod().Name);

            Console.Write("Enter a number: ");

            var num = Console.ReadLine();

            var sum = 0;

            for (int i = 0; i < num.Length; i++)
            {
                sum += int.Parse(num[i].ToString());
            }

            Console.WriteLine("Sum of digits in number {0} is {1}", num, sum);

        }

        public static void Way4()
        {


            Console.WriteLine("{0}",
                System.Reflection.MethodBase.GetCurrentMethod().Name);

            Console.Write("Enter a number: ");

            var num = Console.ReadLine();

            var sum = 0;

            var list = new List<int>();

            for (int i = 0; i < num.Length; i++)
            {
                list.Add(int.Parse(num[i].ToString()));
            }

            list.ForEach(delegate (int num2)
            {
                sum += num2;
            });

            Console.WriteLine("Sum of digits in number {0} is {1}", num, sum);

        }

    }
}
