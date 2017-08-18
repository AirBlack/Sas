using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise16
{
    class Exercise16Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter any text: ");
            var str = Console.ReadLine();

            var str2 = str.Substring(str.Length-1,1)+str.Substring(1, str.Length-2)+str.Substring(0, 1);

            Console.WriteLine(str2);
        }
    }
}
