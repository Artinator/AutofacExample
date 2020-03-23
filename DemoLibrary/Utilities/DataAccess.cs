using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Core.Contracts;

namespace DemoLibrary.Utilities
{
    /// <summary>
    /// This  class does not contain any relevant logic besides counting a variable and writing its progress to the console
    /// </summary>
    public class DataAccess : IDataAccess
    {
        private const int SLEEP_MS = 100;
        private const int COUNTS = 10*5;

        public void SaveData(string somefilenameDat)
        {
            Console.WriteLine("Saving to: " +somefilenameDat);
        }

        public void LoadData()
        {
            Console.WriteLine("Loading started!");
            for (int i = 0; i < COUNTS; i++)
            {
                Thread.Sleep(SLEEP_MS);
                Console.WriteLine($"Loading: {(double) i / (double) COUNTS * 100}%");
            }
        }
    }
}
