using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    class Exercise9Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the first number: ");
            int first = int.Parse(Console.ReadLine());
            Console.Write("Input the second number: ");
            int second = int.Parse(Console.ReadLine());
            Console.Write("Input the third number: ");
            int third = int.Parse(Console.ReadLine());
            Console.Write("Input the forth number: ");
            int forth = int.Parse(Console.ReadLine());

            int sum = (first + second + third + forth);

            int aver = sum / 4;

            Console.WriteLine("The average of {0}, {1}, {2} and {3} is: {4}", first, second, third, forth, aver);
            
        }
    }
}
