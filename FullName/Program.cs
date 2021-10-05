using System;

namespace FullName
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first name");
            string userFirstName = Console.ReadLine();

            Console.WriteLine("Enter your last name");
            string userLastName = Console.ReadLine();

            if (userFirstName.Length >userLastName.Length)
            {
                Console.WriteLine("Your first name is longer than your last name");
            }
            else if (userFirstName.Length < userLastName.Length)
            {
                Console.WriteLine("Your last name is longer than your first name");
            }
            else
            {
                Console.WriteLine("Both your first and last name are the same in length");
            }
        }
    }
}
