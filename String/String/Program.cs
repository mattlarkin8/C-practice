using System;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            string myname = "Matthew";

            string message = "My name is " + myname;

            string capsmessage = message.ToUpper();

            string message2 = "ThIs Is A tEsT mEsSaGe";
            string lowmessage = message2.ToLower();



            Console.WriteLine(message);
            Console.WriteLine(capsmessage);
            Console.WriteLine(message2);
            Console.WriteLine(lowmessage);
            Console.Read();
        }
    }
}
