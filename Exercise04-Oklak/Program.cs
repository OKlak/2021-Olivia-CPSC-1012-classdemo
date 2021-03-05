using System;

namespace Exercise04_Oklak
{
    class Program
    {
        static void Main(string[] args)
        {


            string input;
            int mySquare = 0;
            int sumOfSquares = 0;


            //Console.Write("Enter a number:\t");
            //input = Console.ReadLine();


            //if (int.TryParse(input, out mySquare))
            //{
            //    if (mySquare > 0)
            //    {
            //        int loopCount = 1;
            //        do
            //        {
            //            sumOfSquares += loopCount * loopCount;
            //            loopCount++;
            //        }

            //        while (loopCount < mySquare);
            //        Console.WriteLine($"The sum of squares for {mySquare} is {sumOfSquares}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{mySquare} is invalid. Enter a positive greater than 0:\t");
            //    }


            //}
            //else
            //{
            //    Console.WriteLine($"{input} is invalid. Enter a number. ");
            //}

        //PRE TEST SOLUTION
            Console.Write("Enter a number:\t");
            input = Console.ReadLine();


            if (int.TryParse(input, out mySquare))
            {
                if (mySquare > 0)
                {
                    int loopCount = 1;
                    string msg = "";
                    while (loopCount <= mySquare)
                    {
                        msg = msg + $"{loopCount}x{loopCount}+";
                        sumOfSquares += (int)Math.Pow(loopCount, 2);
                        loopCount++;
                    }
                    //Using the string methods called Substring() and Length()
                    int msgLength = msg.Length;
                    msg = msg.Substring(0, msgLength - 1);
                    Console.WriteLine($"The sum of squares for {mySquare} is {msg} = {sumOfSquares}");
                }
                else
                {
                    Console.WriteLine($"{mySquare} is invalid. Enter a positive greater than 0:\t");
                }


            }
            else
            {
                Console.WriteLine($"{input} is invalid. Enter a number. ");
            }



        }
    }
}
