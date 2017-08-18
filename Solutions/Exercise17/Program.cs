using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
17. Write a C# program to create a new string from a given string (length 1 or more ) with the first character added at the front and back.
Sample Output:
Input a string : The quick brown fox jumps over the lazy dog. 
TThe quick brown fox jumps over the lazy dog.T
*/

namespace Exercise17
{
    class Exercise17Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter any text: ");
            var str = Console.ReadLine();

            var str2 = str[0] + str + str[0];

            Console.WriteLine(str2);
        }
    }
}
