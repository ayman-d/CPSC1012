using System;

namespace _2020_01_21_DecisionStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            // generate 2 random numbers between 1 and 9
            int myInt;
            int firstInt;
            int secondInt;
            int result;
            Random myGenerator = new Random();

            // examples of how to use Random generators
            myInt = myGenerator.Next(); // any int
            myInt = myGenerator.Next(100); // any int less than 100
            myInt = myGenerator.Next(5, 100); // any int between 5 and 99

            // assign 2 random numbers to variables
            firstInt = myGenerator.Next(1, 10);
            secondInt = myGenerator.Next(1, 10);

            // ask user for their solution
            Console.WriteLine($"\nWhat is the sum of {firstInt} and {secondInt}?\n");

            // store user input in variable
            result = int.Parse(Console.ReadLine());

            // we can check by writing to the screen the result of the addition == the user input
            Console.WriteLine(result == (firstInt + secondInt));

            // or check the answer equals the addition with an if statement
            if (result == (firstInt + secondInt))
            {
                Console.WriteLine("\nTrue");
            } else
            {
                Console.WriteLine("\nFalse");
            }

            Console.ReadLine();
        }
    }
}
