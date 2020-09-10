using System;

namespace _2020_01_30_ConditionalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int result = int.Parse(Console.ReadLine());

            string sign = (result >= 0) ? "not negative" : "negative";
            Console.WriteLine($"Number is {sign}");
        }
    }
}
