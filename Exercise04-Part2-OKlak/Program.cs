using System;

namespace Exercise04_Part2_OKlak
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input a list of positive numbers from the user and then calculate and display the average age.
            //Use the input of the number zero(i.e. 0) to stop prompting for number

            /*get user to input a positive number
             * if its not a positive number or something else it is an invalid option
             * if it is a positive number keep asking for a positive  number unti they press 0
             * store the amount fo times they have added in a number
             * mean average = input + input / amount
             * if they press 0 stop the wile loop and show them their mean average
             */


            string input;
            int meanAverage = 0;
            int amount = 0;
            int inputNumber = 0;


            Console.WriteLine("This program asks you to enter multiple numbers and will then find the mean average.");

            do
            {
                Console.Write("\nEnter a number that is >= 1 or press 0 to exit/show your sum:\t");
                input = Console.ReadLine();
                if (input.ToUpper() != "0")
                {
                    //is the data of the correct datatype
                    if (int.TryParse(input, out inputNumber))
                    {
                        //validating that the input number is >= 1
                        if (inputNumber >= 1)
                        {
                            //Assume that data is good
                            meanAverage += inputNumber;
                            amount++;  //fast way to add 1 to a counter
                        }
                        else
                        {
                            Console.WriteLine($"Your number {inputNumber} is not a positive number. Your value is rejected. Try again.");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Your entered value {input} is not valid. Your value is invalid and rejected. Try again");
                    }
                }
            } while (input.ToUpper() != "0");

            if (amount == 0)
            {
                Console.WriteLine("\nYou did not enter any positive numbers.");
            }
            else
            {
                Console.WriteLine($"\nYou entered {amount} positive numbers. Your mean average is {Math.Round((decimal)meanAverage / (decimal)amount, 1)}");
            }
        }
    }
}

