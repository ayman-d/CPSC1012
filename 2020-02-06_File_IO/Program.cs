using System;
using System.IO;

namespace _2020_02_06_File_IO
{
    class Program
    {
        static void Main(string[] args)
        {
            // writing to a file
            /*StreamWriter writer = new StreamWriter("c:\\users\\aaldali2\\test.txt");
            writer.WriteLine("hello world");
            writer.Close();*/

            // reading from a file
            /*StreamReader reader = new StreamReader("test.txt");
            string line = reader.ReadLine();
            Console.WriteLine(line);
            reader.Close();*/

            // reading from a file with a known length
            /*StreamReader reader = new StreamReader("test.txt");
            string line;
            for (int i = 0; i < 3; i++)
            {
                line = reader.ReadLine();
                Console.WriteLine(line);
            }
            reader.Close();*/

            // reading from a file with unknown length
            /*StreamReader reader = new StreamReader("test.txt");
            while (reader.EndOfStream == false)
            {
                string line = reader.ReadLine();
                Console.WriteLine(line);
            } // end while
            reader.Close();*/
        }
    }
}
