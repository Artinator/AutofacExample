using System;
using Core.Contracts;
using DemoLibrary.Utilities;

namespace DemoLibrary
{
    public class BusinessLogic : IBusinessLogic
    {
        public void ProcessData()
        {
            ConsoleLogger log = new ConsoleLogger();
            DataAccess dataAccess = new DataAccess();

            log.Log("[BusinessLogic]: Starting");
            dataAccess.LoadData();

            dataAccess.SaveData("SomeFileName.dat");
            log.Log("[BusinessLogic]: Done");
        }

    }
}
