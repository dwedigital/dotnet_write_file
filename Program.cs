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
            Console.WriteLine("How many entries do you have?");

            // variable for number of lines a user wants to add
            string number = Console.ReadLine();

            Input(number);

        }

        public static void Input(string number)
        {
            // convert string to int as readline is string
            int inputNumber = Convert.ToInt16(number);

            // create a new List to add lines to
            List<string> Lines = new List<string>();
            Console.WriteLine("Enter what you would like to add:");
            for (int i = 0; i < inputNumber; i++)
            {
                Console.WriteLine(">>");

                // get user input
                string input = Console.ReadLine();
                Lines.Add(input);
            }
            Write(Lines);
        }
        public static void Write(List<string> Lines)
        {
            // write all the lines in the Lines List
            File.AppendAllLines("./file.txt", Lines);


        }
    }
}
