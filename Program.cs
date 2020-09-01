using System;

namespace CSharpHelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //wassup this is a comment
            Console.WriteLine("Hello! How you doing?");
            string doing = Console.ReadLine();
            Console.WriteLine($"Oh so you're {doing}, that's cool.");
        }
    }
}
