using System;
using System.Collections.Generic;
using System.Text;
using Core.Contracts;

namespace DemoLibrary.Utilities
{
    internal class ConsoleLogger : ILogger
    {
        public void Log(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
