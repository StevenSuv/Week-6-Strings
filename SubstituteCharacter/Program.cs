using System;

namespace SubstituteCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first name:");
            string userFirstName = Console.ReadLine();

            Console.WriteLine("Enter your last name:");
            string userLastName = Console.ReadLine();

            string fullName = $"{userFirstName}{userLastName}".ToLower();

            fullName = fullName.Replace('a', '*');

            Console.WriteLine(fullName);
        }
    }
}
