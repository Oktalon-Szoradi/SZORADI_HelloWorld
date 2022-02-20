using System;

namespace HelloWorld_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Hello {Environment.UserName}!");
            Console.WriteLine("It's nice to meet you!");

            Console.WriteLine("How are you?\n > ");
            string answer = Console.ReadLine();

            Console.WriteLine($"You're {answer}? That's good to know");

            Console.WriteLine("\nWell, have a nice day now!")
        }
    }
}
