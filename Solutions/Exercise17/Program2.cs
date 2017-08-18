using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise17
{
    class Exercise17Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter any text: ");
            var str = Console.ReadLine();

            var str2 = str.Substring(0, 1) + str + str.Substring(0, 1);

            Console.WriteLine(str2);
        }
    }
}
