using System;

namespace HelloWorld_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Hello {Environment.UserName}!");
            Console.WriteLine("It's nice to meet you!");
            int max = int.MaxValue;
            Console.WriteLine($"\n\nint.MaxValue ({max}) + 1 = {max + 1}");
            Console.WriteLine("\nFloating-Point Numbers:");
            Console.WriteLine($"0.1 + 0.2 = {0.1 + 0.2}");
        }
    }
}
