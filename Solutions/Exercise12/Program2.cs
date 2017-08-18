using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12
{
    class Exercise12Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a digit: ");
            var num = int.Parse(Console.ReadLine());

            var list = new List<int>();
            for(int i=0;i<4;i++)
            {
                list.Add(num);
            }
            for(int i=0;i<4;i++)
            {
                string sep = "";
                if(i%2==1)
                {
                    sep = " ";
                }
                list.ForEach(delegate(int num2)
                {
                    Console.Write(num2+sep);
                });
                Console.Write("\n");
            }
        }
    }
}
