using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise13
{
    class Exercise13Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a digit: ");
            var num = int.Parse(Console.ReadLine());

            var list = new List<int>();
            for(int i=0;i<2;i++)
            {
                list.Add(num);
            }
            for(int i=0;i<5;i++)
            {
                var sep = " ";
                if((i == 0) || (i==4))
                {
                    sep = num.ToString();
                }
                Console.WriteLine(String.Join(sep, list));
            }
        }
    }
}
