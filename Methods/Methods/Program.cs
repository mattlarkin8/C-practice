using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteSomething();
            WriteSomethingSpecific("I am an argument and am called from a method.");
            Console.WriteLine(Add(15, 31));
            Console.WriteLine(Add(Add(1, 2), Add(3, 4)));
            Console.WriteLine(Mult(8, 7));
            Console.WriteLine(Div(12,7));
            Console.Read();
        }
        //access modifier (static) return type method name (parameter1, parameter2)
        public static void WriteSomething()
        {
            Console.WriteLine("I am called from a method.");
        }

        public static void WriteSomethingSpecific(string myText)
        {
            Console.WriteLine(myText);
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Mult(int num1, int num2)
        {
            return num1 * num2;
        }

        public static double Div(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}
