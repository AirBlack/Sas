using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
26. Write a C# program to compute the sum of the first 500 prime numbers.
Sample Output:
Sum of the first 500 prime numbers:
3682913 
 */

namespace Exercise26
{

    class Exercise26Program
    {
        static void Main(string[] args)
        {

            Way1(args);

        }

        public static void Way1(string[] args)
        {


            Console.WriteLine("{0}",
                System.Reflection.MethodBase.GetCurrentMethod().Name);

            var sum = 0;


            var i = 0;
            var nums = 0;
            while(i <= 500)
            {
                if(IsPrime(nums))
                {
                    sum += nums;
                    i++;
                    Console.WriteLine(nums);
                }
                nums++;
            }

            Console.WriteLine("Sas : {0}, Sos : {1}", nums.ToString(), i.ToString());

            Console.WriteLine("Sum of first 500 prime numbers is {0}", sum);

        }

        public static bool IsPrime(int num)
        {
            var isprime = true;

            if (num == 1) return false;
            if (num == 2) return true;

            for(int i = 2; i<=num; i++)
            {
                if((i != 1) && (i != num) && (num % i == 0))
                {
                    isprime = false;
                    break;
                }
            }

            return isprime;
        }

    }
}
