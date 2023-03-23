using System;

namespace testrepo
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Bye World!");
            SomeFunction();
        }

        private static void SomeFunction()
        {
            Console.WriteLine("Byez");
        }
    }
}
