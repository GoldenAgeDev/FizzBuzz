using System;

namespace FizzBuzzConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // For nums 1 - 100, call FizzBuzz function
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(Logic.FizzBuzz(i));
            } // List of answers complete

            // Console remains open
            Console.ReadLine();
        }
    }
}