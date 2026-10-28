using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExcercise
{
    internal class program2 : IStartable
    {
        //internal void Go()
        //{
        //    Console.WriteLine("Nu kör vi program 2");
        //}
        public void start()
        {
            Console.WriteLine("I also implement the interface IStartable");
        }
    }
}
