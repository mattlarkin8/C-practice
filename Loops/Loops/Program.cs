using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
           // for loop
            for(int counter = 1; counter < 20; counter += 2)
            {
                Console.WriteLine(counter);
            }

            // do while loop
            int lengthOfText = 0;
            string wholeText = "";
            do
            {
                Console.WriteLine("Please enter the name of a friend:");
                string nameOfFriend = Console.ReadLine();
                int currentLength = nameOfFriend.Length;
                lengthOfText += currentLength;
                wholeText += nameOfFriend;
            } while (lengthOfText < 20);
            Console.WriteLine("Thanks, that was enough." + wholeText);

            */

            // while loop
            string input = string.Empty;                    // alt solution
            int c = 0;                                      // int i = 0;
            int i = 0;                                      // string input = "";
            while(c == 0)                                   // while(input.Equals(""))
            {                                               // {
                input = Console.ReadLine();                 // i++;
                if (input.Equals(""))                       // Console.WriteLine($"Total Count: {i}");
                {                                           //}
                    i++;
                    Console.WriteLine(i);
                }
                else
                {
                    c++;
                    Console.WriteLine($"Total Count: {i}");
                }
                    
            }

            for(int a = 0; a < 10; a++)
            {
                if(a %2 == 0)
                {
                    Console.WriteLine("Next is odd!");
                    continue;
                }
                Console.WriteLine(a);
            }


            Console.Read();
        }
    }
}
