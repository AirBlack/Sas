using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
2. Write a C# Sharp program to print the sum of two numbers.
*/

namespace Exercise2
{
    class Exercise2Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sum of two numbers.");
            Console.Write("Enter first number: ");
            int first = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int second = int.Parse(Console.ReadLine());
            int sum = first + second;
            Console.WriteLine("{0} + {1} = {2}", first, second, sum);
        }
    }
}
