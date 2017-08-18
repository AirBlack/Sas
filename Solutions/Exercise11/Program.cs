using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11
{
    class Exercise11Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter your age: ");
            var age = int.Parse(Console.ReadLine());

            Console.WriteLine("You look older than {0}", age);
        }
    }
}
