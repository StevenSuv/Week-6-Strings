using System;

namespace ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            string helloWorld = "Hello world!";

            int counter = 0;

            foreach(char character in helloWorld)
            {
                counter = counter + 1;
            }

            Console.WriteLine($"{helloWorld} is {counter} characters long");
        }
    }
}
