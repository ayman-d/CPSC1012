using System;
using System.Collections.Generic;

namespace _2020_03_24_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = new List<int>();

            myList.Add(3);
            myList.Add(5);
            myList.Add(3);
            myList.Add(5);
            myList.Add(3);
            myList.Add(5);
            myList.RemoveAt(5);
            Console.WriteLine(myList[4]);

            // can create a list of objects
            // List<VideoGameCharacter> myCharList = new List<VideoGameCharacter>();

            Console.ReadLine();
        }
    }
}
