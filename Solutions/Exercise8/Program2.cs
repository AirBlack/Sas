using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    class Exercise8Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the number: ");
            int num = int.Parse(Console.ReadLine());

            var numarray = new int[11] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach(int num2 in numarray)
            {
                Console.WriteLine("{0} * {1} = {2}", num, num2, (num * num2));
            }
            
        }
    }
}
