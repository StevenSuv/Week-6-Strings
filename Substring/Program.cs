using System;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string helloWorld = "Hello World!";
            string partToLookFor = "hello";

            bool isThere;

            isThere = helloWorld.ToLower().Contains(partToLookFor);

            if(isThere)
            {
                Console.WriteLine($"Found {partToLookFor}!");
            }
            else
            {
                Console.WriteLine($"Couldn't find {partToLookFor}");
            }
        }
    }
}
