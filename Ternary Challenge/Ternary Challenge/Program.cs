using System;

namespace Ternary_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp = 0;
            string weather;
            Console.WriteLine("What is the temperature?");
            string inputTemp = Console.ReadLine();
            try
            {
                temp = int.Parse(inputTemp);
            }
            catch (FormatException)
            {
                Console.WriteLine("Not a valid temperature.\nPlease input a number:");
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input, please try again.");
                throw;
            }

            weather = temp < 15 ? "It is too cold here." : temp > 28 ? "It is hot here." : "It is ok.";
            Console.WriteLine(weather);
            Console.Read();
        }

        static void altSolution()
        {
            int temp = 0;
            string tempMessage = string.Empty;
            string inputTemp = string.Empty;

            Console.WriteLine("Enter the current temperature:");
            inputTemp = Console.ReadLine();

            bool validInt = int.TryParse(inputTemp, out temp);

            if (validInt)
            {
                tempMessage = temp <= 15 ? "It is too cold here." : temp >= 27 ? "It is hot here" : "It is ok here";
                Console.WriteLine(tempMessage);            
            }
            else
                Console.WriteLine("Invalid input, please enter a number.");


        }
    }
}
