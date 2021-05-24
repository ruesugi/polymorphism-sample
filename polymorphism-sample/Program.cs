using System;

namespace polymorphism_sample
{
    class Program
    {
        static void Main()
        {
            new ReadProcess(ReadProcess.Setting.FILE);
            new ReadProcess(ReadProcess.Setting.NETWORK);
            Console.ReadLine();
        }
    }
}
