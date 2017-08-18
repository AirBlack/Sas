using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
13. Write a C# program that takes a number as input and then displays a rectangle of 3 columns wide and 5 rows tall using that digit.
Test Data:
Enter a number: 5 
Expected Output:
555 
5 5
5 5 
5 5 
555
*/

namespace Exercise13
{
    class Exercise13Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a digit: ");
            var num = int.Parse(Console.ReadLine());

            var list = new List<string>();
            for(int i=0;i<5;i++)
            {
                var sep = " ";
                if ((i == 0) || (i == 4))
                {
                    sep = num.ToString();
                }
                list.Add(num.ToString() + sep + num.ToString()+"\n");
            }

            Console.WriteLine(String.Join("", list));
        }
    }
}
