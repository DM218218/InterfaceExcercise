using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExcercise
{
    internal class program3 : IRunner, IJogger
    {
        int IJogger.run()
        {
            Console.WriteLine("This is IJogger.run");
            return 7;
        }

        void IRunner.run()
        {
            Console.WriteLine("This is IRunner.run");
        }
    }
}
