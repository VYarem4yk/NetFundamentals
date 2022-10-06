using System;

namespace Task1_CoreConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input – user name: ");
            string username = null;
            while (string.IsNullOrEmpty(username))
            {
                username = Console.ReadLine();
            }
            Console.WriteLine($"Hello {username}!");
            Console.ReadLine();
        }
    }
}
