using System;

namespace iteration_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*This program will accept a principle investment amount, a monthlu interest rate,
             * and a investment time in months
             * will display a monthly investment report using the incoming data
             * it will continure until the user enters an x to exit
             */

            /*PROCESS: declare/assign starting variables
             * request execution or exit from the user
             * on exit terminate program
                * on execution input investment values
                * iterate monthly earnings and report
                * on termination of investmentperiod, display a summary
                */

            /*This example sis one of using nested loops
             * menu loop will be a post-test loop
             * investment loop will be a pre-test loop using for()
             * output will demonstrat formatting of values and columns
             */
            string inputTemp;
            decimal myPrincipal = 0.0m;  //the m "types" this numeric as a decimal
            decimal myMonthlyInterestRate = 0.0m;
            Int32 myInvestmentTime = 0; //Int32 is equalivant to int

            string menuChoice = "";

            do
            {
                Console.WriteLine("Welcome to CPSC Investments:\n\n");
                Console.WriteLine("a) investment:");
                Console.WriteLine("x) to exit\n");
                Console.Write("Enter your menu choice:\t");
                menuChoice = Console.ReadLine();

                switch (menuChoice.ToUpper())
                {
                    case "A":
                        {
                            //for this example, I will assume valid data is entered
                            Console.Write("\nEnter your principal investment amount:\t");
                            inputTemp = Console.ReadLine();
                            myPrincipal = decimal.Parse(inputTemp);
                            Console.Write("\nEnter your investment monthly rate (3% -> 0.03):\t");
                            inputTemp = Console.ReadLine();
                            myMonthlyInterestRate = decimal.Parse(inputTemp);
                            Console.Write("\nEnter your investment period in months:\t");
                            inputTemp = Console.ReadLine();
                            myInvestmentTime = Int32.Parse(inputTemp);

                            //use a loop for a fix amount of iterations
                            //best candidate would be a pre-test loop
                            // a) While with a counter
                            // b) for ( ...) loop  my choice!!!!!!!!!!
                            for (int monthIterator = 0; monthIterator < myInvestmentTime; monthIterator++)
                            {
                                // the {0} is referred to as a placeholder
                                // the string.Format(format pattern, value for the pattern)
                                // pattern is currency and the 0 indicates a placeholder for the value
                                //    in the .Format method)
                                Console.Write("\nOpening; {0}\t", string.Format("{0:c}", myPrincipal));

                                //.ToString("pattern")
                                //# indicates a digit position and is optional, printed if NOT zero (0)
                                //0 indicates a digit position and is required, zeroes are printed
                                Console.Write("Interest Paid: {0}\t",
                                    (myPrincipal * myMonthlyInterestRate).ToString("$###,##0.00"));

                                myPrincipal += myPrincipal * myMonthlyInterestRate;

                                //{variable,xcolumnwidth:pattern}
                                // variable is myPrincipal
                                // x column width is 15 spaces, positive value is right align, negative
                                //       value is left align
                                //c stands for currency with a $ sign
                                Console.Write($"Closing: {myPrincipal,15:c}\n");
                                //Console.Write($"Closing: {myPrincipal,15:$###,##0.00}\n");
                            }

                            Console.WriteLine($"Closing {myPrincipal.ToString("c"),20}");
                            break;
                        }
                    case "x":
                        {
                            Console.WriteLine("\nThank you. Good-Bye.\n");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("\nYou entry for the menu choice is invalid. Try again.\n");
                            break;
                        }
                }
            } while (menuChoice.ToLower() != "x");
            string msg = "Good luck on your future investments.";
            for (int i = 0; i < msg.Length; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine($"\n{msg}\n");
            for (int i = 0; i < msg.Length; i++)
            {
                Console.Write("*");
            }
        }
    }
}