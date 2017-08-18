using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    class Exercise7Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the first number: ");
            int first = int.Parse(Console.ReadLine());
            Console.Write("Input the second number: ");
            int second = int.Parse(Console.ReadLine());

            Console.WriteLine("{0} + {1} = {2}", first, second, (first + second));
            Console.WriteLine("{0} - {1} = {2}", first, second, (first - second));
            Console.WriteLine("{0} x {1} = {2}", first, second, (first * second));
            Console.WriteLine("{0} / {1} = {2}", first, second, (first / second));
            Console.WriteLine("{0} mod {1} = {2}", first, second, (first % second));

        }
    }
}
