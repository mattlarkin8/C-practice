using System;

namespace Challenge_Datatypes_and_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            byte Byte = 8;
            Console.WriteLine(Byte);
            SByte Sbyte = 8;
            Console.WriteLine(Sbyte);
            int Int = 32;
            Console.WriteLine(Int);
            short Short = 16;
            Console.WriteLine(Short);
            long Long = 64;
            Console.WriteLine(Long);
            float Float = 32f;
            Console.WriteLine(Float);
            double Double = 64.00;
            Console.WriteLine(Double);
            char Char = 'M';
            Console.WriteLine(Char);
            bool Bool = true;
            Console.WriteLine(Bool);
            string String1 = "I control text";
            Console.WriteLine(String1);
            string String2 = "88";
            int intString = int.Parse(String2);
            Console.WriteLine(intString);
            Console.Read();
        }
    }
}
