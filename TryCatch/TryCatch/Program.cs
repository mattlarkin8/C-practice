using System;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Division Calc\nEnter Numerator:");
            string input1 = Console.ReadLine();
            Console.WriteLine("Enter Denominator:");
            string input2 = Console.ReadLine();
            
            try
            {
                double num1 = double.Parse(input1);
                double num2 = double.Parse(input2);
                Console.WriteLine(Divide(num1, num2));
            }
            catch (FormatException)
            {
               Console.WriteLine("Format exception, please make sure you enter a number.");
            }
            catch(OverflowException)
            {
                Console.WriteLine("Overflow excption, numer was too long or too short for Int32.");
            }
            catch(ArgumentNullException)
            {
                Console.WriteLine("Argument Null Exception, the value was empty.");
            }
            finally
            {
                //Console.WriteLine("This is called no matter what.");
            }
            Console.Read();
        }
        public static double Divide(double num1, double num2)
        {
            return num1 / num2;
        }


    }
}
