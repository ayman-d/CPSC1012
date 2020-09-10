using System;

namespace _2020_02_06_Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 5;
            int j = 0;

            // normally:
            /*Console.WriteLine(i/j);*/

            // ===========================================================

            // using an if statement (not the best)
            /*if (j != 0)
                Console.WriteLine(i / j);
            else
                Console.WriteLine("Cannot divide by zero.");*/

            // ===========================================================

            // catching the exception
            /*try
            {
                // we'll try to run the code in this block. 
                // if any of it fails, we jump to the catch block.    
                Console.WriteLine(i / j);
            } catch
            {
                // this code will only run if there was an exception in the try block.    
                Console.WriteLine("Cannot divide by zero.");
            }*/

            // ===========================================================

            // catching specific error message
            /*try
            {
                Console.WriteLine(i / j);
            } // end try
            catch (Exception ex)
            {
                Console.WriteLine("Cannot divide by zero.");
                Console.WriteLine(ex.Message);
            } // end catch*/

            // ===========================================================

            // the finally block
            /*try
            {
                Console.WriteLine(i / j);
            }// end try
            catch (Exception ex)
            {
                Console.WriteLine("Cannot divide by zero.");
                Console.WriteLine(ex.Message);
            }// end catch
            finally
            {
                Console.WriteLine("We got to the finally block!");
            }// this code will run whether or not there's an exception*/

            // ===========================================================

            // handling many possible exceptions
            /*try
            {
                Console.WriteLine(i / j);
            } // end try
            catch (DivideByZeroException ex)
            { // most specific exception first
                Console.WriteLine("Division Error: " + ex.Message);
            } // end catch
            catch (ArithmeticException ex)
            {
                Console.WriteLine("Math Error: " + ex.Message);
            } // end catch
            catch (Exception ex)
            {
                Console.WriteLine("General Error: " + ex.Message);
            } // end catch*/
        }
    }
}
