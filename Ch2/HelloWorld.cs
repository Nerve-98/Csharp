using System;
using static System.Console;

namespace BrainSharp
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Usage : HelloWorld.exe <name>");
                return;
            }
            WriteLine("Hello, {0}!", args[0]);
        }
    }
}