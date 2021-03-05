using System;

namespace arrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] dieFace;
            dieFace = new int[6];
            int[] die2Face = new int[6] { 1, 2, 3, 4, 5, 6 };
            int[] die3Face = new int[6] { 1, 2, 3, 4, 5, 6 };
            int[] die3Alternative = { 1, 2, 3, 4, 5, 6 };

            string[] dieFaceName = { "One", "Two", "Three", "Four", "Five", "Six" };

            for (int index = 0; index < 6; index++)
            {
                Console.WriteLine($"Default value {die2Face[index]} " +
                    $"Assigned value {die3Face[index]} Face Name {dieFaceName[index]}");
            }
        }
    }
}
