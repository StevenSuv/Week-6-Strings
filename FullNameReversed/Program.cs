using System;

namespace FullNameReversed
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first name:");
            string userFirstName = Console.ReadLine();

            Console.WriteLine("Enter your last name:");
            string userLastName = Console.ReadLine();

            for (int i = userFirstName.Length - 1; i >= 0; i--)
            {
                Console.Write(userFirstName[i]);
            }
            Console.WriteLine();

            for (int i = userLastName.Length - 1; i >= 0; i--)
            {
                Console.Write(userLastName[i]);
            }
        }
    }
}
