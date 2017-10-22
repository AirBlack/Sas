using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PrimeNumbersCounter
{
    class Program
    {

        static List<decimal> numList = new List<decimal>();

        static void Main(string[] args)
        {
            LoadFile();

            Console.WriteLine("Enter a command\nType 'help' for list of commands.");

            while (true)
            {
                var cmd = Console.ReadLine();

                switch(cmd.ToLower())
                {
                    case "exit":
                        Environment.Exit(0);
                        break;
                    case "help":
                        Console.WriteLine("'help' - list of commands\n'calcnumbers' - calculate prime numbers\n'calcsum' - calculate sum of first n prime numbers\n'shownumbers' - show current saved list of prime numbers\n'exit' - exit program");
                        break;
                    case "calcnumbers":
                        Console.WriteLine("Enter number of numbers to check: ");
                        var num = decimal.Parse(Console.ReadLine());
                        CalcNumbers(num);
                        break;
                    case "calcsum":
                        Console.WriteLine("Enter number of first prime numbers to calculate sum: ");
                        var num2 = int.Parse(Console.ReadLine());
                        CalcSum(num2);
                        break;
                    case "shownumbers":
                        PrintList();
                        break;
                    default:
                        Console.WriteLine("Wrong command: {0}", cmd.ToLower());
                        break;

                }
            }
        }

        public static bool IsPrime(decimal num)
        {
            var isprime = true;

            if (num == 1) return false;
            if (num == 2) return true;

            foreach(decimal i in numList)
            {
                if (num % i == 0)
                {
                    isprime = false;
                    break;
                }
            }

            return isprime;
        }

        static void CalcNumbers(decimal num)
        {
            var lastnum = numList.Last();
            for (decimal i = lastnum + 1m; i < (lastnum + num + 1m); i++)
            {
                if (IsPrime(i))
                {
                    Console.WriteLine("Found prime number: {0}", i);

                    numList.Add(i);
                }
            }

            SaveFile();

        }

        static void CalcSum(int num)
        {
            var sum = 0m;

            if (numList.Count >= num)
            {

                sum = numList.GetRange(0, num).Sum();

                Console.WriteLine("Sum of first {0} numbers is {1}", num, sum);
            }
            else
            {
                Console.WriteLine("Not enough calculated prime numbers.");
            }
        }

        static void LoadFile()
        {
            var filename = "db.txt";
            var fullpath = Directory.GetCurrentDirectory() + "\\" + filename;

            if (File.Exists(fullpath))
            {
                using (StreamReader sr = new StreamReader(fullpath))
                {
                    var rawData = sr.ReadToEnd();

                    char[] seps = { ' ' };

                    var temp = rawData.Split(seps);

                    foreach(string i in temp)
                    {
                        numList.Add(decimal.Parse(i));
                    }
                    sr.Close();
                }
            }
            else
            {
                numList.Add(2m);
            }
        }

        static void SaveFile()
        {
            var filename = "db.txt";
            var fullpath = Directory.GetCurrentDirectory() + "\\" + filename;

            if (!File.Exists(fullpath))
            {
                var sr = File.Create(fullpath);
                sr.Close();
            }

            var temp = new List<string>();

            foreach(decimal i in numList)
            {
                temp.Add(i.ToString());
            }

            var whattowrite = String.Join(" ", temp.ToArray());

            File.WriteAllText(fullpath, whattowrite);
        }

        static void PrintList()
        {
            Console.WriteLine("Current saved list of prime numbers: ");
            foreach (decimal i in numList)
            {
                Console.WriteLine("{0}", i);
            }
        }
    }
}
