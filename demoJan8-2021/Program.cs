using System;

namespace demoJan8_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;

            int mySquare = 0;

            Console.Write("Enter a number and find out its sum of squares\t");
            input = Console.ReadLine();

            /*xxx.TryParse takes the input string and attempts to convert the string
             * to the requested numeric data type
             * if the attempt is good then the value is placed in the out variable
             */
            if(int.TryParse(input, out mySquare))
            {
                if(mySquare > 0)
                {

                }

            }
            else
            {
                Console.WriteLine($"{mySquare} is invalid. Enterr a number.\t");
            }

        }
    }
}
