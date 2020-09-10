using System;

namespace _2020_01_28_Else_If
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare variables
            double fahrenheit, celsius;

            // prompt user for input and assign value to variable
            Console.WriteLine("Pleas enter the temperature in fagrenheit: ");
            fahrenheit = double.Parse(Console.ReadLine());

            // calculate celsius
            celsius = (fahrenheit - 32) * (5.0 / 9.0);

            // find which category and display message to user
            if (celsius < 0)
            {
                Console.WriteLine("it's freezing out!");
            }
            else if (celsius < 15)
            {
                Console.WriteLine("wear a jacket.");
            }
            else if (celsius <= 30)
            {
                Console.WriteLine("it's a lovely day!");
            }
            else
            {
                Console.WriteLine("it's finally summer!");
            }
        }
    }
}
