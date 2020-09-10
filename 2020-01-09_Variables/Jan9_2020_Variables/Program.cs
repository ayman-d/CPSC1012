using System;


namespace Jan9_2020_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //get first and second number from user & assign to a variable
            int firstNum = 10, secondNum = 3;

            //calculate sum
            int sum = firstNum + secondNum;
            //calculate diff
            int difference = firstNum - secondNum;
            //calculate product
            int product = firstNum * secondNum;
            //calculate quotient
            //multiply by 1.0 to convert it into a double that display the decimal values
            double quotient = firstNum * 1.0 / secondNum;

            //display what the two numbers are
            Console.WriteLine($"The numbers are {firstNum} and {secondNum}");
            //display the results sum
            Console.WriteLine($"The sum is: {sum}");
            //display the results difference
            Console.WriteLine($"The difference is: {difference}");
            //display the results product
            Console.WriteLine($"The product is: {product}");
            //display the results quotient
            Console.WriteLine($"The quotient is: {quotient}");
            
        }
    }
}
