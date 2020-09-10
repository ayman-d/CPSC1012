using System;

namespace TryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            string rawInput;
            int userAge;
            //bool parsed = true;

            //Console.WriteLine("Enter your age? ");
            //rawInput = Console.ReadLine();
            //userAge = int.Parse(rawInput);

            // TryParse returns true or false depending on whether it was able to parse or not

            do
            {
                Console.WriteLine("Enter your age? ");
                rawInput = Console.ReadLine();          
            } while (int.TryParse(rawInput, out userAge) == false);

            Console.WriteLine(userAge);

            Console.ReadLine();
        }
    }
}
