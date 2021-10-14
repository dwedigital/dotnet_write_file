using System;
using System.Collections.Generic;
using System.IO;


namespace console_test
{
    class Program
    {
        static void Main(string[] args)
        {
            // create an array of strings from the file that is read
            string[] Lines = File.ReadAllLines("./file.txt");

            // iterate through each line and console it
            foreach (string line in Lines)
            {
                Console.WriteLine(line);
            }

            Console.WriteLine("Enter what you would like to add:");
            // get a string from user input
            string input = Console.ReadLine();

            // create an array of legnth 1 for the inputted string
            // added \n to ensure a new line each time
            string[] writeLines = new string[1] { $"\n{input}" };

            //call function Write with the array
             Write(writeLines);
        }
        //using async due to append all text being asyncrhonous
        public static async void Write(string[] writeLines)
        {
            // write each line to the file (only ever one in this case)
            foreach (string line in writeLines)
            {
                await File.AppendAllTextAsync("./file.txt", line);
            }


        }
    }
}
