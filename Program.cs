using System;

namespace InterfaceExcercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            program1 prog1 = new();
            program2 prog2 = new();
            IRunner runner = new program3();
            IJogger jogger = new program3();

            //prog1.run();
            //prog2.Go();

            prog1.start();
            prog1.Fly();
            prog2.start();
            runner.run();
            var r = jogger.run();
            Console.WriteLine($"IJogger.run returned: {r}");

            Console.WriteLine();
            Console.WriteLine("Press any key to end.");
            Console.ReadKey();
        }
    }
}
