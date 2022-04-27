using System;

namespace If_Statement_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("To register, please enter your username:");
            string userName = Console.ReadLine();
            Console.WriteLine("Please enter a password:");
            string password = Console.ReadLine();
            Console.WriteLine("Registration Complete\n---------------------------------------");
            Console.WriteLine("Please Login\nEnter your username:");
            string userNameInput = Console.ReadLine();
            Console.WriteLine("Enter your password:");
            string passwordInput = Console.ReadLine();
            if (userNameInput == userName && passwordInput == password)
            {
                Console.WriteLine("You are logged in.");
            }
            else
            {
                Console.WriteLine("Incorrect username or password.");
            }
        }
    }
}
