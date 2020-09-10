using System;

namespace _2020_01_30_SwitchStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare variables
            char response;
            int price;
            const int PRICE_A = 30;
            const int PRICE_B = 20;
            const int PRICE_C = 15;

            // prompt user for input
            Console.WriteLine("Our pet food is available in three grades:\nA, B, C. Which do you want pricing for?\n");
            response = char.Parse(Console.ReadLine());
            response = char.ToUpper(response);
            
            switch (response)
            {
                case 'A':
                    price = PRICE_A;
                    Console.WriteLine($"\nThe price of {response} is {price}");
                    break;
                case 'B':
                    price = PRICE_B;
                    Console.WriteLine($"\nThe price of {response} is {price}");
                    break;
                case 'C':
                    price = PRICE_C;
                    Console.WriteLine($"\nThe price of {response} is {price}");
                    break;
                default:
                    Console.WriteLine("\nThat's not a valid input!");
                    break;
            }
            Console.ReadLine();
        }
    }
}
