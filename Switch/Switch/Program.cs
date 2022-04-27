using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age:");
            string ageInput = Console.ReadLine();
            int age = int.Parse(ageInput);
            switch (age)
            {
                case 15:
                    Console.WriteLine("Too young to party");
                    break;
                case 25:
                    Console.WriteLine("Good to go!");
                    break;
                default:
                    Console.WriteLine("How old are you then?");
                    break;
            }
            Console.WriteLine("Run again");
            if (age == 15)
            {
                Console.WriteLine("Too young to party");
            }
            else if (age == 25)
            {
                Console.WriteLine("Good to go!");
            }
            else
            {
                Console.WriteLine("How old are you then?");
            }

            string username = "matthew";
            
            switch (username)
            {
                case "matthew":
                    Console.WriteLine("Hello matthew");
                    break;
                case "root":
                    Console.WriteLine("Logged in as root");
                    break;
                default:
                    Console.WriteLine("Unknown username");
                    break;
            }

        }
    }
}
