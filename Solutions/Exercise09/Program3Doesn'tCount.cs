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
            var size = 4;
            var list = new List<int>();
            for(int i = 1; i<=size;i++)
            {
                Console.Write("Input number {0}:", i);
                list.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine("The average of {0} is: {1}", String.Join(", ", list), Math.Floor(list.Average()));
        }
    }
}
