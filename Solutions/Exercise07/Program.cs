using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
7. Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying and dividing of two numbers which will be entered by the user.
Test Data:
Input the first number: 25
Input the second number: 4
Expected Output:
25 + 4 = 29
25 - 4 = 21
25 x 4 = 100 
25 / 4 = 6
25 mod 4 = 1
*/

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
