using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
9. Write a C# Sharp program that takes four numbers as input to calculate and print the average. Go to the editor
Test Data:
Enter the First number: 10 
Enter the Second number: 15 
Enter the third number: 20 
Enter the four number: 30 

Expected Output:
The average of 10 , 15 , 20 , 30 is: 18
*/

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
