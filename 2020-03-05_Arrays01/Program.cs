using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] age = new int[6];
            double[] mark = new double[25];
            string[] name = new string[100];
            char[] menuOption = new char[75];

            const int ARRAY_SIZE = 10;
            int[] someNumbers = new int[ARRAY_SIZE];
            Random ranGenerator = new Random();

            for (int index = 0; index < ARRAY_SIZE; index++)
            {
                someNumbers[index] = ranGenerator.Next(1, 11);
                Console.WriteLine(someNumbers[index]);
            }

            

            Console.ReadLine();
        } // end main method
    }
}
