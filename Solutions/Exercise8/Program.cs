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

            for(int i = 0;i<=10;i++)
            {
                Console.WriteLine("{0} * {1} = {2}", num, i, (num * i));
            }
            
        }
    }
}
