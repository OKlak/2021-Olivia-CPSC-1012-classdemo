using System;


namespace Exercise04_Part3_OKlak
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a program that reads in a value N and then prints its digits in a column, starting with the last digit. 
             * E.g. if N = 3456, then the program should print the following:
             * 6
             * 5
             * 4
             * 3
             */


            string input = "";
            int n;
            int position = 0;

            Console.WriteLine("This program allows you to enter a value N and then prints the " +
                "digits in a cloumn, but reveresed");
            Console.WriteLine("_________________________________________________________________________________________________");

            Console.Write("\nEnter a positive number:\t");
            input = Console.ReadLine();

            while (!int.TryParse(input, out n))
            {
                Console.WriteLine($"You have entered {input}. That is invalid.");
                Console.Write("\nEnter a positive number:\t");
                input = Console.ReadLine();
            }
            while (position < input.Length)
            {
                Console.WriteLine($"\n{input.Substring(input.Length - 1 - position, 1)}");
                position++;
            }


            //string input;
            //Console.Write("Enter a number and it will display digits in reverse order:\t");
            //input = Console.ReadLine();
            //int number;
            //if (int.TryParse(input, out number))
            //{
            //    int numberLength = input.Length;
            //    for (int loopCounter = numberLength - 1; loopCounter >= 0; loopCounter--) 
            //    {
            //        Console.WriteLine($"{input.Substring(loopCounter, 1)}");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine($"{input} is invalid. Enter a number");
            //}

        }
    }
}

