using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExcercise
{
    internal class program1 : IStartable, IFlyable
    {
        //internal void run()
        //{
        //    Console.WriteLine("Nu kör vi program 1");
        //}

        public void start()
        {
            Console.WriteLine("I implement the interface IStartable");
        }
        public void Fly()
        {
            Console.WriteLine("In addition I implement the interface IFlyable");
        }
    }
}
