using System;

namespace StringsAndArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            string userFirstName = Console.ReadLine();

            Console.WriteLine($"Your name is {userFirstName.Length} characters long.");
        }
    }
}
