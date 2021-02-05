using System;

namespace Exercise2_P3_OKlak
{
    class Program
    {
        static void Main(string[] args)
        {
            /*enter the height (a) String(float)
             *enter the base (b) String(float)
             *make c a double float
             *Math.Sqrt(c) Console.Write(Math.Sqrt(c));
             *double sqrtVal;
             *sqrtVal = Math.sqrt(number)
             */
            Console.WriteLine("√a2 + b2 = √c2");
            Console.Write("Enter the height value for a: ");
            string a = Console.ReadLine();
            Console.Write("Enter the base value for b: ");
            string b = Console.ReadLine();

            double height = double.Parse(a);
            double base1 = double.Parse(b);
            double multiply = (height * height) + (base1 * base1);
            double squared = (height * height);
            double squared2 = (base1 * base1);

            Console.WriteLine($"Your height squared is {squared} and your base squared is {squared2} = {multiply}");
            Console.WriteLine($"(√{multiply})= {Math.Sqrt(multiply)}");
           

           

               








        }
    }
}




//res = Math.Sqrt(val1 * val1 + val2 * val2);