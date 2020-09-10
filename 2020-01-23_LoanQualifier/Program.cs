using System;

namespace _2020_01_23_LoanQualifier
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare variables
            double yearlyWage, jobYears;

            // prompt user for information
            Console.WriteLine("Please provide the following information\n");
            Console.Write("What is your yearly salary amount in dollars?: ");
            yearlyWage = double.Parse(Console.ReadLine());
            

            // check if conditions are met and display result
            if (yearlyWage >= 30000)
            {
                // if condition for salary is met ( >= 30000 )
                Console.Write("How many years have you been at your job?: ");
                jobYears = double.Parse(Console.ReadLine());
                if (jobYears >= 2)
                {
                    // if condition for years is met ( >= 2 )
                    Console.WriteLine("\nCongrats! you qualify for a loan!");
                } else
                {
                    // if condition for years fails ( < 2 )
                    Console.WriteLine("\nSorry, but you haven't been on your job long enough to qualify for a loan");
                }
            } else
            {
                // if condition for salary fails ( < 30000 )
                Console.WriteLine("\nSorry, but your salary is too low to qualify for a loan");
            } // end method
        } // end class
    } // end namespace
}
