using System;

namespace exercise2_P4_Oklak
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Program will prompt the user for a 3 digit number
             * then calculate the sum of the digits of the number
             * will then display both the number and the sum of its digits
             * Created by: Olivia Klak
             * Last modified 2021-01-25 10:24
             */

            int inputNumber;
            int moduel;
            int sum = 0;

            //prompt user to enter a number
            Console.Write("Enter a three-digit whole number: ");

            //parse input to an integer from string so it can be used in calculations
            inputNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("The integer is : " + inputNumber);

            while (inputNumber > 0)
            {
                moduel = inputNumber % 10;
                sum = sum + moduel;
                inputNumber = inputNumber / 10;

            }

            Console.Write("The sum of the three digits ' " + sum);


        }
    }
}
