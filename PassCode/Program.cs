using System;

namespace Passcode
{
    class Program
    {
        static void Main(string[] args)
        {
            var code = "";
            
            while (code != "secret")
            {
                Console.WriteLine("Enter your pasword!");
                code = Console.ReadLine();

                if (code != "secret")
                {
                    Console.WriteLine("Try again");
                }
            }
            Console.WriteLine("Pasword is correct");
        }



    }
}
