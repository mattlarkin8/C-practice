using System;

namespace Loop_Challenge
{
    class Program
    {
        static int sum = 0;
        static int entries = 0;
        static void Main(string[] args)
        {

            
            int counter = 0;
            string inputString = string.Empty;
            int input;
            int result;

            while (counter != -1)
            {
                Console.WriteLine("Enter score or enter -1 for average:");
                inputString = Console.ReadLine();
                if (int.TryParse(inputString, out result))
                {
                    input = result;
                    if (input > -1 && input < 21)
                    {
                        Console.WriteLine($"Entered Value: {input}");
                        sum = sum + input;
                        Console.WriteLine($"Current Sum: {sum}");
                        entries++;
                        Console.WriteLine($"Current # of entries: {entries}");
                    }
                    else if (input < -1 || input > 20)
                    {
                        Console.WriteLine("Invalid input. Enter a score 0-20.");
                    }
                    else
                    {
                        counter--;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Enter a score 0-20.");
                }
            }
            if (counter == -1)
            {
                Average();
            }
                
            Console.WriteLine("Start over?(yes/no)");
            string restart = Console.ReadLine().ToUpper();
            Console.WriteLine($"\nRestart: {restart}");
            if (restart.Equals("YES"))
            {
                counter++;
                Console.WriteLine($"\nCounter: {counter}");
            }
            else if (restart.Equals("NO"))
            {
                Console.WriteLine("\nAre you sure you want to exit?(yes/no)");
                string exit = Console.ReadLine().ToUpper();
                //exit = char.ToUpper(exit);
                Console.WriteLine($"\nExit: {exit}");
                if (exit.Equals("YES"))
                {
                    Environment.Exit(0);
                }
                else
                {
                    counter++;
                    Console.WriteLine($"\nCounter: {counter}");
                }
            }
            else
            {
                Console.WriteLine("\nInvalid Input. Enter yes to restart program or no to exit.");
                Console.WriteLine($"\nRestart: {restart}");
            }
        }

        public static void Average()
        {
            double average = (double)sum / (double)entries;
            Console.WriteLine($"Average Score: {average}");
        }
    }
}
