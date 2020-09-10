using System;

namespace _2020_01_21_DecisionStructure02
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare variables
            double firstScore;
            double secondScore;
            double thirdScore;
            double averageScore;

            // prompt user to provide 3 scores
            Console.Write("Pleas enter your first score: ");
            firstScore = double.Parse(Console.ReadLine());
            Console.Write("Pleas enter your second score: ");
            secondScore = double.Parse(Console.ReadLine());
            Console.Write("Pleas enter your third score: ");
            thirdScore = double.Parse(Console.ReadLine());

            // calculate average score
            averageScore = (firstScore + secondScore + thirdScore) / 3;

            // display average score
            Console.WriteLine($"\nYour average score is {Math.Round(averageScore, 1)}");

            // congratulate user if average is more than 95
            if (averageScore > 95)
            {
                Console.WriteLine("\nCongratulations, you achieved a high score average!");
            } // end if

            Console.ReadLine();
        }
    }
}
