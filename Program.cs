using System;
using System.Collections.Generic;
using System.IO;


namespace console_test
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Lines = File.ReadAllLines("./file.txt");

            foreach (string line in Lines)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine("Enter what you would like to add:");

            string input = Console.ReadLine();

            string[] writeLines = new string[1] { $"\n{input}" };

             Write(writeLines);
        }
        public static async void Write(string[] writeLines)
        {
            foreach (string line in writeLines)
            {
                await File.AppendAllTextAsync("./file.txt", line);
            }


        }
    }
}
