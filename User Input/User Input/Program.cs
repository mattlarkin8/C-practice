using System;

namespace User_Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I can add numbers! Give it a try.\nEnter first number to add:");
            string input1 = Console.ReadLine();
            Console.WriteLine("Enter second number to add:");
            string input2 = Console.ReadLine();
            int num1 = int.Parse(input1);
            int num2 = int.Parse(input2);
            Console.WriteLine(Add(num1, num2));
            Console.Read();
        }

        public static int Add(int num1, int num2)
        {
            return (num1 + num2);
        }
    }
}
