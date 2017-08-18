using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    class Exercise6Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the first number to multiply: ");
            int first = int.Parse(Console.ReadLine());
            Console.Write("Input the sceond number to multiply: ");
            int second = int.Parse(Console.ReadLine());
            Console.Write("Input the third number to multiply: ");
            int third = int.Parse(Console.ReadLine());

            Console.WriteLine("{0} * {1} * {2} = {3}", first, second, third, (first * second * third));

        }
    }
}
