
using System;

namespace operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 3;
            int num3;

            //unary operator
            num3 = -num1;
            Console.WriteLine($"num3 is {num3}.");
            // ! negates true/false (! = not)
            bool isSunny = true;
            Console.WriteLine($"Is it sunny? {!isSunny}");

            //increment operators
            int num = 0;
            num++;
            Console.WriteLine($"num is {num}.");
            // post increment
            Console.WriteLine($"num is {num++}.");
            // pre increment
            Console.WriteLine($"num is {++num}.");
            //decrement operator
            num--;
            Console.WriteLine($"num is {num}");
            //post
            Console.WriteLine($"num is {num--}");
            //pre
            Console.WriteLine($"num is {--num}");

            int result;
            result = num1 + num2;
            Console.WriteLine($"result of num1 + num2 is {result}");
            result = num1 - num2;
            Console.WriteLine($"result of num1 - num2 is {result}");
            result = num1 / num2;
            Console.WriteLine($"result of num1 / num2 is {result}");
            result = num1 * num2;
            Console.WriteLine($"result of num1 * num2 is {result}");
            // % divides Variable 1 by Variable 2 then gives remainder
            result = num1 % num2;
            Console.WriteLine($"result of num1 % num2 is {result}");

            //relational and type operators
            bool isLower;
            isLower = num1 > num2;
            Console.WriteLine($"result of num1 > num2 is {isLower}");

            //equality operator
            bool isEqual;
            isEqual = num1 == num2;
            Console.WriteLine($"result of num1 == num2 is {isEqual}");

            isEqual = num != num2;
            Console.WriteLine($"result of num1 != num2 is {isEqual}");

            //conditional operators
            bool isLowerAndSunny;
            // condition 1 AND condition 2
            isLowerAndSunny = isLower && isSunny;
            Console.WriteLine($"result of isLower && isSunny is {isLowerAndSunny}");
            //condition 1 OR condition 2
            isLowerAndSunny = isLower || isSunny;
            Console.WriteLine($"result of isLower || isSunny is {isLowerAndSunny}");
            Console.Read();
        }
    }
}
