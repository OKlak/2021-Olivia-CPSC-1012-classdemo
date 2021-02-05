using System;

namespace Arithmetic2_OKlak
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me three real numbers and I will " +
                "compute their mean average!");


            Console.Write("\nWhat is your first number? \t");
            string numberOne = Console.ReadLine();
            Console.Write("What is your second number? \t");
            string numberTwo = Console.ReadLine();
            Console.Write("What is your third number? \t");
            string numberThree = Console.ReadLine();




            double First = double.Parse(numberOne);
            double Second = double.Parse(numberTwo);
            double Third = double.Parse(numberThree);
            double Add = (First + Second + Third);
            double meanAverage = (Add / 3);

            Console.WriteLine($"{numberOne} + {numberTwo} + {numberThree} = {Add} / 3 = {meanAverage}");
            Console.WriteLine($"\nYour mean average is {Math.Round(meanAverage,2)}");
        }
    }
}
