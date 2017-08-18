using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
6. Write a C# Sharp program to print the output of multiplication of three numbers which will be entered by the user. 
Test Data:
Input the first number to multiply: 2
Input the second number to multiply: 3
Input the third number to multiply: 6
Expected Output:
2 x 3 x 6 = 36
*/

namespace Exercise6
{
    class Exercise6Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the first number to multiply: ");
            int first = int.Parse(Console.ReadLine());
            Console.Write("Input the second number to multiply: ");
            int second = int.Parse(Console.ReadLine());
            Console.Write("Input the third number to multiply: ");
            int third = int.Parse(Console.ReadLine());

            Console.WriteLine("{0} * {1} * {2} = {3}", first, second, third, (first * second * third));

        }
    }
}
