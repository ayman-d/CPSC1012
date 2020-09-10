using System;
using System.Collections.Generic;
using System.Text;

namespace _2020_03_19_VideoGame
{
    class VideoGameCharacter
    {
        private string Name;
        private string Specialty; // e.g. strength, agility, etc...
        private string Species; // e.g. human, elf, etc..
        private int Level = 1;
        private int Hp = 100; // TO DO: set iniatial value in our constructor
        private int Xp; // TO DO: how to initialize?

        // static field
        private static string[] Specialties = { "Agility", "Strength", "Dexterity", "Stamina" };

        // Constructor
        public VideoGameCharacter()
        {
            Console.Write("What is your character's name?: ");
            this.Name = Console.ReadLine(); // todo: add validation
            SetSpecialty();
            Console.Write("What is your character's species?: ");
            this.Species = Console.ReadLine(); // todo: add validation
        } // end of consturctor method

        // == Accessors ==
        // name
        public string GetName ()
        {
            return this.Name;
        }
        // level
        public int GetLevel()
        {
            return this.Level;
        }
        // hp
        public int GetHP()
        {
            return this.Hp;
        }

        // == Mutators ==
        // specialty: compare to an array of predefined specialties, if wrong prompt until correct
        public void SetSpecialty ()
        {
            string newSpecialty;
            bool isFound;

            do
            {
                Console.Write("Enter new specialty: ");
                newSpecialty = Console.ReadLine();
                Program.SearchArray(Specialties, newSpecialty, out isFound);

            } while (!isFound);
            this.Specialty = newSpecialty;
        } 


        // hp: > 0 and < level * 100, if invalid return error
        public void SetHP()
        {
            Console.Write("What is the HP of this character?: ");
            int newHp = Program.GetPositiveInt();

            if (newHp > 0 && newHp <= (this.Level * 100))
            {
                this.Hp = newHp;
            } else
            {
                Console.WriteLine("That is not a valid value (must be between 0 and Level * 100)");
            }
        }


        // == Any other methods ==
        // level up: increase level by 1
        public void LevelUp ()
        {
            this.Level++;
            this.Hp += 100;
        }
        // display character info: this will show all of the attributes
        public void DisplayCharacterInfo ()
        {
            Console.WriteLine($"Name: {this.Name}\nSpecialty: {this.Specialty}\nSpecies: {this.Species}\nLevel: {this.Level}\nHP: {this.Hp}\nXP: {this.Xp}");
        }
        // complete mission: display a success message, increase xp by a given amount
        public void CompleteMission (int Xp)
        {
            Console.WriteLine("Congrats! you successfully completed the mission");
            this.Hp += 50;
            this.Xp += Xp;
        }
        

    }

}
