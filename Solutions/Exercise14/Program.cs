using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise14
{
    class Exercise14Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the amount of celsius: ");
            var cel = int.Parse(Console.ReadLine());

            Console.WriteLine("Kelvin = {0}", (273 + cel));
            Console.WriteLine("Fahrenheit = {0}", (32 + cel*1.8));
        }
    }
}
