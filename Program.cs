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
            string number = Console.ReadLine();

            Input(number);

        }

        public static void Input(string number)
        {
            int inputNumber = Convert.ToInt16(number);
            List<string> Lines = new List<string>();
            Console.WriteLine("Enter what you would like to add:");
            for (int i = 0; i < inputNumber; i++)
            {
                Console.WriteLine(">>");
                string input = Console.ReadLine();
                Lines.Add(input);
            }
            Write(Lines);
        }
        public static void Write(List<string> Lines)
        {

            File.AppendAllLines("./file.txt", Lines);


        }
    }
}
