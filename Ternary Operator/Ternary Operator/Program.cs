using System;

namespace Ternary_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            // condition ? first_expression : second_expression
            //condition must be true or false
            //conditional operator is right - associative
            //The expression a ? b : c ? d : e
            //is evaluated as a ? b : (c ? d : e),
            //not as (a ? b : c) ? d : e
            //conditional operator cannot be overloaded
            int temp = -5;
            string stateOfMatter;

            /*
            if (temp < 0)
                stateOfMatter = "solid";
            else
                stateOfMatter = "liquid";

            Console.WriteLine($"State of matter is {stateOfMatter}");
            */

            //short version
            temp += 30;
            stateOfMatter = temp > 100 ? "gas" : temp < 0 ? "solid" : "liquid";

            Console.WriteLine($"State of matter is {stateOfMatter}");
            Console.Read();
        }
    }
}
