using System;

namespace InputOutputMath
{
    class Program
    {
        static void Main(string[] args)
        {
            ////*Implement a temperature coverter from Celsius to Fahrenheit

            ////input: Celsius temperature
            ////      string intTemp
            ////      double theCelsiusTemperature

            ////output: Fahrenheit temperature
            ////        double theFahrenheitTemperature

            ////expression (calculate): (ct * 9.0/5.0) + 32
            ////check with ct = 0 expect ft = 32
            ////check with ct = 100 expect ft = 212
            ////check with ct = -40   expect ft = -40

            ////prompt for a celsius temperature
            //// .Write() keeps your cursor on the same line
            //Console.Write("Enter a celsius temperature: ");

            ////How does the prgoram pull in the entry from the user
            ////to obtain the key stokes that the user typers (user input)
            //// .ReadLine()
            ////IMPORTANT
            ////data comes into the program as a string
            ////DOES NOT matter if you enter a number, it is treated as a string

            //string inputTemp;
            ////assignment statement: expression on the right is placed into the variable on the left
            ////expression (action):  read te user input 
            //inputTemp = Console.ReadLine();

            ////you ould do both statements on one line
            ////string inputTemp = Console.ReadLine();

            ////currently the celsius value is a string
            ////the value needs to be converted to a number to be used in a math calculation
            ////convert the data to a different datatype
            ////to do this; you will use technique called parsing
            ////syntax: datatypeTo.Parse(string value)

            ////WARNING: I AM ASSUMING THE USER WILL ENTER VALID DATA
            ////if the user does not entar a number this program will abort on the execution of this line
            //double theCelsiusTemperature = double.Parse(inputTemp);


            ////calculation using the conversion expression
            //double theFahrenheitTemperature =
            //    (theCelsiusTemperature * (9.0/5.0)) + 32;

            ////output
            //// .WriteLine()which automaticaly goes to the next line
            //Console.WriteLine($"The Celsius temperature of {theCelsiusTemperature}" +
            //    $" is {theFahrenheitTemperature} in Fahrenheit. ");

            int experience;
            double bonus, totalIncome;
Console.Write("Please enter the total income: ");
            totalIncome = double.Parse(Console.ReadLine());

            Console.Write("Please enter the experience: ");
            experience = (int)double.Parse(Console.ReadLine());

            if (experience < 5) ;
            {
                bonus = totalIncome * experience / 100.0;
            }

        }
    }
}
