using System;

namespace Nested_If_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isAdmin = false;
            bool isRegistered = true;
            Console.WriteLine("Please enter user name");
            string userName = Console.ReadLine();

            if (isRegistered && userName != "")
            {
                Console.WriteLine("Hello, registered user.");
               
                Console.WriteLine($"Hello, {userName}");
                if (userName.Equals("admin"))
                {
                    Console.WriteLine("Hello, Admin.");
                }
            }
            if(isAdmin || isRegistered)
            {
                Console.WriteLine("You are logged in.");
            }

            Console.ReadKey();
        }
    }
}
