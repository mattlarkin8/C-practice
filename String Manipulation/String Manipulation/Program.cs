using System;

namespace String_Manipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 25;
            string name = "Matthew";
            string job = "Developer";

            //string concatenation
            Console.WriteLine("Hello my name is " + name + ", I am " + age + " years old.");

            //String formatting using index
            Console.WriteLine("Hello my name is {0}, I am {1} years old. I'm a {2}.", name, age, job);

            //String interpolation
            //Uses $ at beginning to allow variable to be written as {variableName}
            Console.WriteLine($"Hello my name is {name}, I am {age} years old.");

            //Verbatim strings
            //Starts with @ and tells compiler to take the string literally, ignoring all spaces and escape characters
            Console.WriteLine(@"C:\User\Admin\Documents\Schedule.txt");
            Console.Read();
        }
    }
}
