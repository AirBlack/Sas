using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
16. Write a C# program to create a new string from a given string where the first and last characters will change their positions.
Test Data:
w3resource
Python
Sample Output:
e3resourcw
nythoP 
*/

namespace Exercise16
{
    class Exercise16Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter any text: ");
            var str = Console.ReadLine();

            var str2 = str;

            str2 = str2.Remove(0, 1);
            str2 = str2.Remove(str2.Length - 1, 1);
            str2 += str[0];
            str2 = str[str.Length-1] + str2;
            Console.WriteLine(str2);
        }
    }
}
