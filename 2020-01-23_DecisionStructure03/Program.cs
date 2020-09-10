using System;

namespace _2020_01_23_DecisionStructure03
{
    class Program
    {
        static void Main(string[] args)
        {
            // generate 2 random poditive single digit numbers and declare variables
            Random numberGenerator = new Random();
            int firstNumber = numberGenerator.Next(1, 10);
            int secondNumber = numberGenerator.Next(1, 10);
            int answer;
            string userMessage = "\nYour answer is ";
            
            // order the numbers from bigger to smaller
            if (firstNumber < secondNumber)
            {
                int placeHolder = secondNumber;
                secondNumber = firstNumber;
                firstNumber = placeHolder;
            }

            // prompt answer from user
            Console.WriteLine($"What is the difference between {firstNumber} and {secondNumber}?");
            Console.Write("\nAnswer: ");
            answer = int.Parse(Console.ReadLine());

            // check the answer correctness and display result
            if (answer == firstNumber - secondNumber)
            {
                userMessage += "correct!";
            } else
            {
                userMessage += "wrong!";
            }

            Console.WriteLine(userMessage);

            Console.ReadLine();
        }
    }
}
