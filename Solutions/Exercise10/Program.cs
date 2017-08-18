using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
10. Write a C# Sharp program to that takes three numbers(x,y,z) as input and print the output of (x+y).z and x.y + y.z.
Test Data:
Enter first number - 5
Enter second number - 6
Enter third number - 7

Expected Output:
Result of specified numbers 5, 6 and 7, (x+y).z is 77 and x.y + y.z is 72
*/

namespace Exercise10
{
    class Exercise10Program
    {
        static void Main(string[] args)
        {

            Console.Write("Write number x: ");
            var x = int.Parse(Console.ReadLine());
            Console.Write("Write number y: ");
            var y = int.Parse(Console.ReadLine());
            Console.Write("Write number z: ");
            var z = int.Parse(Console.ReadLine());

            Console.WriteLine("(x + y).z = {0}", ((x+y)*z));
            Console.WriteLine("x.y + y.z = {0}", (x*y + y*z));
        }
    }
}
