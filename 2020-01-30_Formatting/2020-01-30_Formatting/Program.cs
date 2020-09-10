using System;

namespace _2020_01_30_Formatting
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNum = 43554, secondNum = 6.5465465469865;

            // change text color
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.White;
            // replace any missing numbers from this format with 0
            // the number before the colon is for left and right alignment and how wide the column is
            Console.WriteLine($"1st num is {firstNum, 15:$0,000.00}.");
            
            // replace any missing numbers from this format with nothing
            Console.WriteLine($"2nd num is {secondNum, -15:$#,##0.00}.");
            // currency format
            Console.WriteLine($"1st num is {firstNum, 20:c}");

            // reset color
            Console.ResetColor();

            // to have different colors between display and input
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("What is your name? ");
            Console.ForegroundColor = ConsoleColor.Blue;
            string name = Console.ReadLine();

            Console.ReadLine();
        }
    }
}
