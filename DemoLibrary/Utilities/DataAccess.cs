using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Core.Contracts;

namespace DemoLibrary.Utilities
{
    internal class DataAccess : IDataAccess
    {
        private const int SLEEP_MS = 250;
        private const int COUNTS = 4 * 5;

        public void SaveData(string somefilenameDat)
        {
            Console.WriteLine("Saving to: " +somefilenameDat);
        }

        public void LoadData()
        {
            Console.WriteLine("Loading");
            for (int i = 0; i < COUNTS; i++)
            {
                Thread.Sleep(SLEEP_MS);
            }
        }
    }
}
