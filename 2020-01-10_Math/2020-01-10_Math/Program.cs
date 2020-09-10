using System;

namespace _2020_01_10_Math
{
    class Program
    {
        static void Main(string[] args)
        {
            double quotient = 10 / 3.0;
            // display the full double digits
            Console.WriteLine(quotient);
            // Math.Round gets rid of the decimals
            Console.WriteLine("My number is {0}", Math.Round(quotient));
            // Math.Round and specify the number of decimals
            Console.WriteLine("My number is {0}", Math.Round(quotient, 3));

            // to use "power to" exponents
            double myNum = Math.Pow(2, 6);
            // display it
            Console.WriteLine("My answer is {0}",myNum);

            // to use square root method
            double newNum = Math.Sqrt(25);
            Console.WriteLine("The square root is {0}", newNum);

            // for more visit MSDN C# and search

            Console.WriteLine("==================================");

            // different ways to insert variables into strings
            int firstNum = 5, secondNum = 56, thirdNum = 1;
            Console.WriteLine("My numbers are " + firstNum + ", " + secondNum + ", and " + thirdNum + ".");
            Console.WriteLine("My numbers are {0}, {1}, and {2}.", firstNum, secondNum, thirdNum);
            Console.WriteLine($"My numbers are {firstNum}, {secondNum}, and {thirdNum}.");
        }
    }
}
