using System;

namespace ClassesAndObjects01
{
    class Program
    {
        static void Main(string[] args)
        {
            // create an instance of dog
            Dog fido = new Dog("Fido");
            Dog spot = new Dog("Spot", "Beagle", 20, "Black");

            Console.WriteLine(spot.GetName());

            Console.Write("What is your doggo's name?: ");
            string dogName = Console.ReadLine();
            fido.SetName(dogName);
            Console.WriteLine(fido.GetName());

            Console.Write("What is your doggo's weight?: ");
            int dogWeight = GetPositiveHighInt();
            fido.SetWeight(dogWeight);
            if (dogWeight > 0)
            {
                Console.WriteLine($"Your dog weighs {fido.GetWeight()} kgs.");
            }

            Console.ReadLine();
        } // end of main method

        static int GetPositiveHighInt()
        {
            string positiveInt;
            int userInt = 0; // initialization value
            bool breakLoop = false;
            do
            {
                positiveInt = Console.ReadLine();
                try
                {
                    userInt = int.Parse(positiveInt);
                    breakLoop = true;
                } // end try
                catch
                {
                    Console.WriteLine($"Invalid input: {positiveInt}, try again.");
                }
            } while (!breakLoop);
            return userInt;
        } // end of getNumYears()
    } // end of program class
} // end of namespace
