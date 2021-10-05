using System;

namespace ACharacterCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first name");
            string userFirstName = Console.ReadLine();

            Console.WriteLine("Enter your last name");
            string userLastName = Console.ReadLine();

            string fullName = $"{userFirstName}{userLastName}".ToLower();

            int counter = 0;

            foreach(char character in fullName)
            {
                if(character == 'a')
                {
                    counter++;
                }
            }

            Console.WriteLine($"Sinu nimes on {counter} a-tähte");
        }
    }
}
