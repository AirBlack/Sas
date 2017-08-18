using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
5. Write a C# Sharp program to swap two numbers. 
Test Data:
Input the First Number : 5
Input the Second Number : 6
Expected Output: 
After Swapping :
First Number : 6 
Second Number : 5 
*/

namespace Exercise5
{
    class Exercise5Program
    {
        static void Main(string[] args)
        {
            int first = 0;
            int second = 0;

            Console.Write("Input the First Number:");
            first = int.Parse(Console.ReadLine());
            Console.Write("Input the Second Number:");
            second = int.Parse(Console.ReadLine());

            int blank = second;
            second = first;
            first = blank;

            Console.WriteLine("After Swapping:\nFirst Number: {0}\nSecond Number: {1}", first, second);

        }
    }
}
