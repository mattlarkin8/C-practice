using System;

namespace IF_statements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the temperature right now?");
            string input = Console.ReadLine();
            int temp;
            int number;
            if(int.TryParse(input, out number))
            {
                temp = number;
            }
            else
            {
                temp = 0;
                Console.WriteLine("Value entered was invalid. 0 set as temp.");

            }
            if (temp < 50)
            {
                Console.WriteLine("Take your coat.");
            }
            else if (temp == 50)
            {
                Console.WriteLine("It's 50 degrees.");
            }
            else
            {
                Console.WriteLine("Not so cold out.");
            }
            Console.Read();
        }
    }
}
