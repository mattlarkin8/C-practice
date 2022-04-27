using System;

namespace ReadLine_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = string.Empty;
            string userFood = string.Empty;
            string message = string.Empty;

            Console.WriteLine("What is your name?");
            userName = Console.ReadLine();
            Console.WriteLine("What is your favorite food?");
            userFood = Console.ReadLine();
            Console.WriteLine($"Hello {userName}. I like {userFood} too!");
            Console.WriteLine("Do you want to be friends?\n(Enter yes or no)");
            string response = Console.ReadLine().ToUpper();
           
            
            message = response.Equals("YES") ? $"That's great {userName}, I'm happy we can be friends!" : response.Equals("NO") ? $"That's too bad {userName}. Deleting system32..." : "Input error. Please enter yes or no.";
            Console.WriteLine(message);
            Console.Read();
        }
    }
}
/*if(response.Equals("YES"))
           {
               Console.WriteLine($"That's great {userName}, I'm happy we can be friends!");
           }
           else if (response.Equals("NO"))
           {
               Console.WriteLine($"That's too bad {userName}. I'm now formatting your hard drive.");
           }
           else
           {
               Console.WriteLine("Input error. Please enter yes or no.");
           }*/