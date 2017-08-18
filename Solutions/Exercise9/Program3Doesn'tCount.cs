using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    class Exercise9Program
    {
        static void Main(string[] args)
        {
            var size = 4;
            var list = new List<int>();
            for(int i = 1; i<=size;i++)
            {
                Console.Write("Input number {0}:", i);
                list.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine("The average of {0} is: {1}", String.Join(", ", list), Math.Floor(list.Average()));
        }
    }
}
