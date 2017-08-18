using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
8. Write a C# Sharp program that takes a number as input and print its multiplication table.
Test Data:
Enter the number: 5
Expected Output:
5 * 0 = 0
5 * 1 = 5
5 * 2 = 10 
5 * 3 = 15
....
5 * 10 = 50
*/

namespace Exercise8
{
    class Exercise8Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the number: ");
            int num = int.Parse(Console.ReadLine());

            for(int i = 0;i<=10;i++)
            {
                Console.WriteLine("{0} * {1} = {2}", num, i, (num * i));
            }
            
        }
    }
}
