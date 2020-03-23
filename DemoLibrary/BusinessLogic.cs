using System;
using Core.Contracts;
using DemoLibrary.Utilities;

namespace DemoLibrary
{
    /// <summary>
    /// the businesslogic holds the "backend" of processing dummy data
    /// </summary>
    public class BusinessLogic : IBusinessLogic
    {
        private ILogger _logger;
        private IDataAccess _dataAccess;

        public BusinessLogic(ILogger logger, IDataAccess dataAccess)
        {
            _logger = logger;
            _dataAccess = dataAccess;
        }

        public void ProcessData()
        {
            _logger.Log("[BusinessLogic]: Starting");
            _dataAccess.LoadData();

            _dataAccess.SaveData("SomeFileName.dat");
            _logger.Log("[BusinessLogic]: Done");
        }

    }
}
