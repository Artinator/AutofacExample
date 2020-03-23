using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Contracts
{
    public interface IDataAccess 
    {
        void LoadData();

        void SaveData(string somefilenameDat);

    }
}
