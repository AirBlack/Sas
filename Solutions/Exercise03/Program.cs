using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
3. Write a C# Sharp program to print the result of dividing two numbers.
*/

namespace Exercise3
{
    class Exercise3Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Divide of two numbers.");
            Console.Write("Enter first number: ");
            double first = double.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            double second = double.Parse(Console.ReadLine());
            try
            {
                double div = first / second;
                Console.WriteLine("{0} / {1} = {2}", first, second, div);
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Can't divide by zero.");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
