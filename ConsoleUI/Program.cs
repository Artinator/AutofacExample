using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Contracts;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            IBusinessLogic logic = null;

            logic.ProcessData();
            
        }
    }
}
