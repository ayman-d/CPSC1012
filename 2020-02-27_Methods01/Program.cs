using System;

namespace _2020_02_27_Methods01
{
    class Program
    {

        // =====================================

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my program.");
            Add2Numbers(2, 3);
            // you can store it in sum because the method now returns an int
            int sum = Add2Numbers(3, 6);
            Console.WriteLine(sum);
        } // end Main() Method
        static int Add2Numbers(int firstNum, int secondNum)
        {
            // we don't even need the writeline, it'll just return the int
            Console.WriteLine($"{firstNum} plus {secondNum} equals {firstNum + secondNum}");
            return firstNum + secondNum;
        }

        // =====================================

        /*Method that takes arguments*/
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Welcome to my program.");
        //    Add2Numbers(2, 3);
        //} // end Main() Method
        //static void Add2Numbers (int firstNum, int secondNum)
        //{
        //    Console.WriteLine($"{firstNum} plus {secondNum} equals {firstNum + secondNum}");
        //}

        // ======================================

        /*Simple Method*/
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Welcome to my program.");
        //    DoSomething();
        //    DoSomething();
        //    DoSomething();
        //} // end Main () Method
        //static void DoSomething()
        //{
        //    Console.WriteLine("Hello");
        //} // end DoSomething() Method
    }
}
