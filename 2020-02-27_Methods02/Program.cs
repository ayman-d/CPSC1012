using System;

namespace _2020_02_27_Methods02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your age? ");
            int age = GetUserInt();
            Console.WriteLine($"Your age is {age}");

            Console.Write("What is your shoe size? ");
            int shoeSize = GetUserInt();
            Console.WriteLine($"Your shoe size is {shoeSize}");

            DisplayInColor($"Shoesize is {shoeSize}");
        } // end Main() method

        static int GetUserInt ()
        {
            return int.Parse(Console.ReadLine());
        } // end GetUserInt() method

        static void DisplayInColor (string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ResetColor();
        } // end DisplayInColor() method
 
    }
}
