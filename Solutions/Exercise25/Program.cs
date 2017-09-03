using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
25. Write a C# program to print the odd numbers from 1 to 99. Prints one number per line.
Sample Output:
Odd numbers from 1 to 99. Prints one number per line.
1 
3 
5 
7 
9 
...
95
97 
99 
 */

namespace Exercise25
{

    class Exercise25Program
    {
        static void Main(string[] args)
        {

            Way1(args);

            Way2();

            Way3();

            Way4();

        }

        public static void Way1(string[] args)
        {
            

            Console.WriteLine("{0}",
                System.Reflection.MethodBase.GetCurrentMethod().Name);

            for(int i = 1; i<100; i+=2)
            {
                Console.WriteLine(i);
            }

        }

        public static void Way2()
        {


            Console.WriteLine("{0}",
                System.Reflection.MethodBase.GetCurrentMethod().Name);

            for (int i = 1; i < 100; i ++)
            {
                if(i%2==1)
                {
                    Console.WriteLine(i);
                }
            }

        }

        public static void Way3()
        {


            Console.WriteLine("{0}",
                System.Reflection.MethodBase.GetCurrentMethod().Name);

            var listofnumbers = Enumerable.Range(0, 100).ToList();


            listofnumbers.ForEach(delegate (int num)
            {
                if(num%2==1)
                {
                    Console.WriteLine(num);
                }
            });

        }

        public static void Way4()
        {
            Console.WriteLine("{0}",
                System.Reflection.MethodBase.GetCurrentMethod().Name);

            var arr = Enumerable.Range(0,100).ToArray();

            foreach(int num in arr)
            {
                if(num%2==1)
                {
                    Console.WriteLine(num);
                }
            }
        }

    }
}
