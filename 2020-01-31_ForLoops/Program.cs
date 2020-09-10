using System;

namespace _2020_01_31_ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare variables
            int userInput;
            int factorial = 1;
            int count;


            // prompt
            Console.Write("Enter Number: \n\n");
            userInput = int.Parse(Console.ReadLine());

            for (count = userInput; count >= 1; count--)
            {
                factorial *= count;
            }

            Console.WriteLine($"\n{userInput}! is {factorial}");

            Console.ReadLine();

        }
    }
}
