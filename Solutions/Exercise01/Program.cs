﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
1. Write a C# Sharp program to print Hello and your name in a separate line.
Expected Output : 
Hello: Alexandra Abramov
*/


namespace Exercise1
{
    class Exercise1Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
			if(string.IsNullOrEmpty(name))
			{
				throw new Exception();
			}
            Console.WriteLine("Hello : {0}", name);
        }
    }
}
