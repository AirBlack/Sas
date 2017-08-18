using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
11. Write a C# Sharp program that takes an age (for example 20) as input and prints something as "You look older than 20". 
Test Data:
Enter your age - 25
Expected Output:
You look older than 25
*/

namespace Exercise11
{
    class Exercise11Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter your age: ");
            var age = int.Parse(Console.ReadLine());

            Console.WriteLine("You look older than {0}", age);
        }
    }
}
