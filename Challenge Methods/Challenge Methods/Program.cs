using System;

namespace Challenge_Methods
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //declare variables to be used in method.
            //**variables must reside in the method where they are used**
            string friend1 = "Jake";
            string friend2 = "Sean";
            string friend3 = "Austin";

            //string written once in method and called multiple times, once per variable
            GreetFriend(friend1);
            GreetFriend(friend2);
            GreetFriend(friend3);

            //string written once per variable in method and called once with multiple variables
            Greeting(friend1, friend2, friend3);
            Console.Read();
        }

        public static void GreetFriend(string friendName)
        {
            Console.WriteLine($"Hello {friendName}, my good friend.");
        }

        public static void Greeting(string friendName, string friendName2, string friendName3)
        {
            Console.WriteLine($"Hello {friendName}, my good friend.");
            Console.WriteLine($"Hello {friendName2}, my good friend.");
            Console.WriteLine($"Hello {friendName3}, my good friend.");
        }
    }
}
