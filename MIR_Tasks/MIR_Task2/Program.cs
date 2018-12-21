using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace MIR_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length >= 3)
            {
                var folderPath = args[0];
                var regExpMasksPath = args[1];
                var resultsPath = args[2];

                if (Directory.Exists(folderPath) && File.Exists(regExpMasksPath))
                {
                    var regExpMasks = File.ReadAllLines(regExpMasksPath).Where((s) => {
                        try
                        {
                            //Filtering regexp matches
                            //This is the only way of checking Regexs for validity I could find.
                            Regex.IsMatch("", s);
                            return true;
                        }
                        catch (ArgumentException)
                        {
                            Console.WriteLine("RegExp {0} was incorrect. Ignoring.", s);
                            return false;
                        }
                    }).Select((s) => new Regex(s)).ToList();//Turning it into List<Regex>
                    File.WriteAllLines(resultsPath, CheckFolder(folderPath, regExpMasks)); 
                    Console.WriteLine("Results written to {0}", resultsPath);
                }
                else
                {
                    Console.WriteLine("Directory or RegExp masks file doesn't exist.");
                }
            }
            else
            {
                Console.WriteLine("Not enough arguments!");
            }

            Console.ReadKey();
        }

        static List<string> CheckFolder(string folderPath, List<Regex> regExps)
        {
            var matchedPathList = new List<string>();

            foreach (var filePath in Directory.GetFiles(folderPath))
            {
                if (regExps.Any(r => r.IsMatch(filePath)))
                {
                    matchedPathList.Add(filePath);
                }
            }

            foreach (var directory in Directory.GetDirectories(folderPath))
            {
                matchedPathList.AddRange(CheckFolder(directory, regExps));
            }

            return matchedPathList;
        }
    }
}
