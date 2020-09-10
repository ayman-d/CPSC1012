using System;

namespace _2020_02_13_Marks
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare variables
            int marksNum;
            int totalMarks = 0;
            double averageScore;

            // prompt user for input
            Console.Write(" How many marks are you entering?: ");
            marksNum = int.Parse(Console.ReadLine());

            // depedning on the number of marks, loop enough times to get the input for each mark
            for (int marksCounter = 1; marksCounter <= marksNum; marksCounter++)
            {
                Console.Write($" Please enter mark # {marksCounter}: ");
                totalMarks += int.Parse(Console.ReadLine());
                // this is the same as markInput = int.Parse... then totalMarks += markInput
                
            }

            averageScore = (double)totalMarks / marksNum;

            // output to user
            Console.WriteLine($"\n Your average mark is {averageScore}");

            // seperator
            Console.ReadLine();

        }
    }
}
