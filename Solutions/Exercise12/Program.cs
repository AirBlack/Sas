using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
12. Write a C# program to that takes a number as input and display it four times in a row (separated by blank spaces), and then four times in the next row, with no separation. You should do it two times: Use Console. Write and then use {0}. 
Test Data:
Enter a digit: 25 
Expected Output:
25 25 25 25 
25252525 
25 25 25 25 
25252525
*/

namespace Exercise12
{
    class Exercise12Program
    {
        static void Main(string[] args)
        {

            Console.Write("{0}","Enter a digit: ");
            var num = int.Parse(Console.ReadLine());

            var list = new List<int>();
            for(int i=0;i<4;i++)
            {
                list.Add(num);
            }
            for(int i=0;i<4;i++)
            {
                if(i%2==0)
                {
                    Console.WriteLine("{0}", String.Join(" ", list));
                }
                else
                {
                    Console.WriteLine("{0}", String.Join("", list));
                }
            }
        }
    }
}
