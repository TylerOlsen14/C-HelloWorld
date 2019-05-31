using System;

namespace StarterHelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Nice to meet you " + name);
            int maxInt = int.MaxValue;
            Console.WriteLine("Max Int: " + maxInt);
        }
    }
}
