using System;

namespace _2020_03_19_VideoGame
{
    class Program
    {
        static void Main(string[] args)
        {
            VideoGameCharacter myCharacter = new VideoGameCharacter();

            myCharacter.SetSpecialty();
            myCharacter.SetHP();
            myCharacter.DisplayCharacterInfo();
            myCharacter.LevelUp();
            Console.WriteLine("LEVEL UP!");
            myCharacter.DisplayCharacterInfo();
            myCharacter.CompleteMission(40);
            myCharacter.DisplayCharacterInfo();
            Console.ReadLine();
        } // end of Main ()



        // ======= extra methods ========
        public static int GetPositiveInt()
        {
            string positiveHighInt;
            int userInt = 0; // initialization value
            bool breakLoop = false;
            do
            {
                positiveHighInt = Console.ReadLine();
                try
                {
                    userInt = int.Parse(positiveHighInt);
                    if (userInt > 0)
                    {
                        breakLoop = true;
                    }
                    else
                    {
                        Console.WriteLine($"Error: Input should be a whole number bigger than 0");
                    }
                } // end try
                catch
                {
                    Console.WriteLine($"Error: Input should be a whole number bigger than 0");
                }
            } while (!breakLoop);
            return userInt;
        } // end of GetPositiveInt()

        public static void SearchArray(string[] arrayName, string searchTerm, out bool isFound)
        {
            isFound = false;
            for (int index = 0; index < arrayName.Length; index++)
            {
                if (arrayName[index] == searchTerm)
                {
                    isFound = true;
                }
            }
        }
    } // end of Program class
} // end of namespace
