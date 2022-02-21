using System;

namespace HelloWorld_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int j = 2;
            i = Add(i, j);
            Console.WriteLine($"i:{i} j:{j}"); // i:3 j:2

            //Console.WriteLine("\nDateTime now:");
            //if (DateTime.TryParse(DateTime.Now.ToString(), out DateTime d))
            //    Console.WriteLine(d.ToString());

            Console.WriteLine("\nDateTime default:");
            if (!DateTime.TryParse("foobar", out DateTime e))
                Console.WriteLine(e.ToString());

            
        }
        static int Add(int n1, int n2)
        {
            //      ++0 + 2++
            //        1 + 2
            return ++n1 + n2++;
        }
    }
}
