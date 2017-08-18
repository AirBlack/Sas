using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    class Exercise10Program
    {
        static void Main(string[] args)
        {

            Console.Write("Write number x: ");
            var x = int.Parse(Console.ReadLine());
            Console.Write("Write number y: ");
            var y = int.Parse(Console.ReadLine());
            Console.Write("Write number z: ");
            var z = int.Parse(Console.ReadLine());

            Console.WriteLine("(x + y).z = {0}", ((x+y)*z));
            Console.WriteLine("x.y + y.z = {0}", (x*y + y*z));
        }
    }
}
