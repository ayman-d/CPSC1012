using System;

namespace _2020_02_25_Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {

            int age;
            bool validInput = false;
            

            do
            {
                try
                {
                    Console.Write("Enter Your Age: ");
                    age = int.Parse(Console.ReadLine());
                    validInput = true;
                    Console.WriteLine($"Your age is {age}!");
                }

                catch (Exception)
                {
                    Console.WriteLine("Sorry, Invalid.");
                }
                
            } while (!validInput);
            Console.WriteLine("We got to the end");
        }

    }
}
