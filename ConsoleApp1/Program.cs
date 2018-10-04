using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main: Hello World!");
            LocalClass.SayHi();
            ClassLibrary1.RemoteClass.SaySomething();
            Console.Write("Press ENTER...");
            Console.ReadLine();
        }
    }

    class LocalClass
    {
        public static void SayHi()
        {
            Console.WriteLine("LocalClass: Hi");
        }
    }
}
