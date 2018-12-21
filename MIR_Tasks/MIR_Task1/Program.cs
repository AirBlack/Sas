using System;
using System.Collections.Generic;
using System.IO;

namespace MIR_Task1
{
    class Program
    {

    

        static void Main(string[] args)
        {
            if (args.Length >= 3)
            {
                var firstFolderPath = args[0];
                var secondFolderPath = args[1];
                var resultsPath = args[2];

                if (Directory.Exists(firstFolderPath) && Directory.Exists(secondFolderPath))
                {
                    using (var resultPathStream = File.CreateText(resultsPath))
                    {
                        var differences = CheckFolder(firstFolderPath, secondFolderPath);

                        if (differences.Count > 0)
                        {
                            differences.ForEach((s) => { resultPathStream.WriteLine(s); });
                        }
                        else
                        {
                            resultPathStream.WriteLine("Every file in first folder is equal to second folder.");
                        }
                        Console.WriteLine("Results written to {0}", resultsPath);
                    }
                }
                else
                {
                    Console.WriteLine("One or both directories doesn't exist.");
                }
            }
            else
            {
                Console.WriteLine("Not enough arguments!");
            }

            Console.ReadKey();
        }

        static List<string> CheckFolder(string firstFolderPath, string secondFolderPath)
        {
            var differenceList = new List<string>();

            foreach (var firstFilePath in Directory.GetFiles(firstFolderPath))
            {
                var secondFilePath = secondFolderPath + Path.DirectorySeparatorChar + Path.GetFileName(firstFilePath);
                if (File.Exists(secondFilePath))
                {
                    var firstFileContents = File.OpenRead(firstFilePath);
                    var secondFileContents = File.OpenRead(secondFilePath);
                    if (firstFileContents.Length == secondFileContents.Length)
                    {
                        while (firstFileContents.Position < firstFileContents.Length)
                        {
                            if (firstFileContents.ReadByte() != secondFileContents.ReadByte())
                            {
                                differenceList.Add(String.Format("{0} is different from file {1}.", firstFilePath, secondFilePath));
                                break;
                            }
                        }
                    }
                    else
                    {
                        differenceList.Add(String.Format("{0} and {1} have different sizes.", firstFilePath, secondFilePath));
                    }

                    firstFileContents.Dispose();
                    secondFileContents.Dispose();
                }
                else
                {
                    differenceList.Add(String.Format("{0} - File {1} does not exist", firstFilePath, secondFilePath));
                }
            }

            foreach (var firstDirectory in Directory.GetDirectories(firstFolderPath))
            {
                var secondDirectory = secondFolderPath + Path.DirectorySeparatorChar + Path.GetFileNameWithoutExtension(firstDirectory);
                if (!Directory.Exists(secondDirectory))
                {
                    differenceList.Add(String.Format("{0} - Folder {1} does not exist.", firstDirectory, secondDirectory));
                }
                //We want to show every different file even if folder doesn't exist
                //If you don't like it then add else block
                differenceList.AddRange(CheckFolder(firstDirectory, secondDirectory));
            }

            return differenceList;
        }
    }
}
