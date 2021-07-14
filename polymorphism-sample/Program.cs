using System;

namespace polymorphism_sample
{
    class Program
    {
        static void Main()
        {
            new ReadProcess("file");
            new ReadProcess("network");
            Console.ReadLine();
        }
    }
}
