using Core.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLibrary
{
    /// <summary>
    /// better businesslogic with upgraded logging features '==='
    /// </summary>
    public class BetterBusinessLogic : IBusinessLogic
    {
        private ILogger _logger;
        private IDataAccess _dataAccess;

        public BetterBusinessLogic(ILogger logger, IDataAccess dataAccess)
        {
            _logger = logger;
            _dataAccess = dataAccess;
        }

        public void ProcessData()
        {
            _logger.Log("[BusinessLogic]: Starting");
            _logger.Log("===========================");
            _dataAccess.LoadData();
            _dataAccess.SaveData("SomeFileName.dat");
            _logger.Log("===========================");
            _logger.Log("[BusinessLogic]: Done");
        }
    }
}
