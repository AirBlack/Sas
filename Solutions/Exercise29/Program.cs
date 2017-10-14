using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


/*
29. Write a C# program to find the size of a specified file in bytes.
Sample Output:
Size of a file: 31 
 */

namespace Exercise29
{

    class Exercise29Program
    {
        static void Main(string[] args)
        {

            Way1(args);

            Way2();

            Way3();

        }

        public static void Way1(string[] args)
        {

            Console.WriteLine("{0}",
                System.Reflection.MethodBase.GetCurrentMethod().Name);

            var filename = args[0];

            var fullpath = Directory.GetCurrentDirectory() + "\\" + filename;

            if (File.Exists(fullpath))
            {
                var fileinfo = new FileInfo(fullpath);

                Console.WriteLine("File path: {0}\nFile size: {1}", fullpath, fileinfo.Length);
            }
            else
            {
                Console.WriteLine("File {0} not found.", fullpath);
            }

        }

        public static void Way2()
        {

            Console.WriteLine("{0}",
                System.Reflection.MethodBase.GetCurrentMethod().Name);

            Console.Write("Write filename that is located at the program directory: ");

            var filename = Console.ReadLine();

            var fullpath = Directory.GetCurrentDirectory() + "\\" + filename;

            if (File.Exists(fullpath))
            {
                FileInfo fileinfo = new FileInfo(fullpath);

                Console.WriteLine("File path: {0}\nFile size: {1}", fullpath, fileinfo.Length);
            }
            else
            {
                Console.WriteLine("File {0} not found.", fullpath);
            }

        }

        public static void Way3()
        {

            Console.WriteLine("{0}",
                System.Reflection.MethodBase.GetCurrentMethod().Name);

            Console.Write("Write filename that is located at the program directory: ");

            var filename = Console.ReadLine();

            var fullpath = Directory.GetCurrentDirectory() + "\\" + filename;
            try
            {

                FileInfo fileinfo = new FileInfo(fullpath);

                Console.WriteLine("File path: {0}\nFile size: {1}", fullpath, fileinfo.Length);

            }
            catch(Exception e)
            {
                Console.WriteLine("{0}, {1}", e.GetType().Name, e.Message);
            }
        }

    }
}
