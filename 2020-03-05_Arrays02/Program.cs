using System;

namespace Arrays02
{
    class Program
    {
        static void Main(string[] args)
        {

            // ask user for array size
            Console.Write("\nHow long is the array you want to create? ");
            int arrayLength = int.Parse(Console.ReadLine());

            // create array
            int[] randomArray = new int[arrayLength];

            // the methods
            LoadArray(randomArray);
            //DisplayArray(randomArray);
            Array.Sort(randomArray);
            DisplayArray(randomArray);

            SearchArray(randomArray);
            //Console.WriteLine(SearchArray(randomArray));

            Console.ReadLine();
        } // end main method

        static void LoadArray(int[] newArray)
        {
            Random ranGenerator = new Random();
            for (int index = 0; index < newArray.Length; index++)
            {
                newArray[index] = ranGenerator.Next(1, 11);
            }
        } // end LoadArray()

        static void DisplayArray(int[] newArray)
        {
            Console.WriteLine("\nYour array is:");
            Console.Write(" ");
            //for (int index = 0; index < newArray.Length; index++)
            //{
            //    Console.Write("----");
            //}

            Console.WriteLine(new string('-', 4*newArray.Length));
            for (int index = 0; index < newArray.Length; index++)
            {
                Console.Write((index == newArray.Length - 1) ? ("| " + newArray[index].ToString() + " |\n") : ("| " + newArray[index] + " "));
            }
            Console.Write(" ");
            Console.WriteLine(new string('-', 4 * newArray.Length));
        } // end DisplayArray()

        static void SearchArray(int[] randomArray)
        {
            int counter = 0;
            int firstIndex = randomArray.Length;
            Console.Write("\n\nWhat number are you looking for? ");
            int search = int.Parse(Console.ReadLine());
            for (int index = 0; index < randomArray.Length; index++)
            {
                if (search == randomArray[index])
                {
                    counter++;
                    if (index < firstIndex)
                    {
                        firstIndex = index;
                    } // end inner if
                } // end if
            } // end for
            if (counter > 0)
            {
                Console.WriteLine($"{counter} instance(s) found");
                Console.WriteLine($"the first index found was {firstIndex}");
            } else
            {
                Console.WriteLine($"no instace(s) of {search} found");
            }
            
        } // end SearchArray()
    }
}
