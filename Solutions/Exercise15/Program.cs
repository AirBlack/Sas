using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
15. Write a C# program remove specified a character from a non-empty string using index of a character. 
Test Data:
w3resource
Sample Output:
wresource
w3resourc
3resource
*/

namespace Exercise15
{
    class Exercise15Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter any text: ");
            var str = Console.ReadLine();

            Console.WriteLine(str.Remove(1, 1));
            Console.WriteLine(str.Remove((str.Length-1), 1));
            Console.WriteLine(str.Remove(0, 1));
        }
    }
}
