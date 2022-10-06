using System;
using Task2_Multitargeting;

namespace Task2_CoreConsoleAppUsesDll
{
    class Program
    {
        static void Main(string[] args)
        {
            Greetings greetings = new Greetings();
            string username =null;
            Console.Write("Input – user name: ");            
            while (string.IsNullOrEmpty(username))
            {
                username = Console.ReadLine();
            }

            string output = greetings.GenerateGreetings(username);
            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}
