using System;
using System.Collections.Generic;
using System.Text;
using Core.Contracts;

namespace DemoLibrary.Utilities
{
    /// <summary>
    /// This is a very simple implementation of a pure console-writeline 'logger'
    /// </summary>
    public class ConsoleLogger : ILogger
    {
        public void Log(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
