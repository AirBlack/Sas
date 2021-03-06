﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
19. Write a C# program to compute the sum of two given integers, if two values are equal then return the triple of their sum.
 */

namespace Exercise19
{
    class Exercise19Program
    {
        static void Main(string[] args)
        {

            Way1(args);

            Way2();

            Way3();

            Way4();

            Way5();

            Way6();

        }

        public static void Way1(string[] args)
        {
            int num1 = int.Parse(args[0]);
            int num2 = int.Parse(args[1]);

            int result = num1 == num2 ? (num1 + num2) * 3 : (num1 + num2);

            Console.WriteLine("{0}: \nGiven numbers: {1}, {2}. Result: {3}",
                System.Reflection.MethodBase.GetCurrentMethod().Name,
                num1, num2, result);

        }

        public static void Way2()
        {
            Console.Write("{0}: \nEnter first number: ",
               System.Reflection.MethodBase.GetCurrentMethod().Name);
            var num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            var num2 = int.Parse(Console.ReadLine());

            int result = num1 + num2;

            if (num1 == num2)
            {
                result *= 3;
            }

            Console.WriteLine("Given numbers: {0}, {1}. Result: {2}", num1, num2, result);
        }

        public static void Way3()
        {
            Console.Write("{0}: \nEnter first number: ",
                System.Reflection.MethodBase.GetCurrentMethod().Name);
            var num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
                var num2 = int.Parse(Console.ReadLine());

            int[] array = { num1, num2 };

            var sum = array.Sum();

            int result = num1 == num2 ? (sum) * 3 : (sum);

            Console.WriteLine("Given numbers: {0}, {1}. Result: {2}",
                num1, num2, result);

        }

        public static void Way4()
        {
            Console.Write("{0}: \nEnter first number: ",
                System.Reflection.MethodBase.GetCurrentMethod().Name);
            var num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            var num2 = int.Parse(Console.ReadLine());

            int[] array = { num1, num2 };

            var sum = 0;

            Array.ForEach(array, delegate(int i) { sum += i; });

            int result = num1 == num2 ? (sum) * 3 : (sum);

            Console.WriteLine("Given numbers: {0}, {1}. Result: {2}",
                num1, num2, result);

        }

        public static void Way5()
        {
            Console.Write("{0}: \nEnter first number: ",
                System.Reflection.MethodBase.GetCurrentMethod().Name);
            var num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            var num2 = int.Parse(Console.ReadLine());

            int[] array = { num1, num2 };

            var sum = 0;

            foreach(int i in array)
            {
                sum += i;
            }

            int result = num1 == num2 ? (sum) * 3 : (sum);

            Console.WriteLine("Given numbers: {0}, {1}. Result: {2}",
                num1, num2, result);

        }

        public static void Way6()
        {
            Console.Write("{0}: \nEnter first number: ",
                System.Reflection.MethodBase.GetCurrentMethod().Name);
            var num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            var num2 = int.Parse(Console.ReadLine());

            int[] array = { num1, num2 };

            var sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            int result = num1 == num2 ? (sum) * 3 : (sum);

            Console.WriteLine("Given numbers: {0}, {1}. Result: {2}",
                num1, num2, result);

        }

    }
}
