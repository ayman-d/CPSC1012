using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesAndObjects01
{
    class Dog
    {
        // creating properties:

        // instance field (specific to each instance created)
        private string Name;
        private string Breed;
        private int Weight; // weight in KG
        private string Colour;

        // static field (applies to the whole Dog class)
        // isn't called with instance like fido.GoodBoy, but 
        private static bool GoodBoy = true;


        public Dog(string name)
        {
            this.Name = name;
        }

        public Dog(string name, string breed, int weight, string colour)
        {
            this.Name = name;
            this.Breed = breed;
            this.Weight = weight;
            this.Colour = colour;
        }

        public string GetName()
        {
            return this.Name;
            // you can just say "return Name" also works
        }

        public int GetWeight()
        {
            return this.Weight;
            // "return Weight" works too
        }

        public void SetName(string newName)
        {
            this.Name = newName;
            // "Name = newName" also works
        }

        public void SetWeight(int newWeight)
        {
            if (newWeight <= 0)
            {
                Console.WriteLine("Weight cannot be negative.");
            }
            else
            {
                this.Weight = newWeight;
            }

        }
    } // end of dog class
} // end of namespace
