using System;

namespace Challenge_String_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string here:");
            string userInput = Console.ReadLine();
            Console.WriteLine("Enter the character to search:");
            char searchInput = Console.ReadLine()[0];
            int searchIndex = userInput.IndexOf(searchInput);
            Console.WriteLine("Index of character {0} in string is {1}", searchInput, searchIndex);

            Console.WriteLine("Enter your first name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter your last name:");
            string lastName = Console.ReadLine();
            string fullName = string.Concat (firstName + " " + lastName);
            Console.WriteLine(fullName);



            Console.Read();
        }
    }
}
