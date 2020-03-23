using ConsoleUI.Contracts;
using Core.Contracts;

namespace ConsoleUI
{
    /// <summary>
    /// Autofac requires a constructor -> create a Application and IApplication interface for resolving it within your main -method
    /// </summary>
    public class Application : IApplication
    {
        IBusinessLogic _businessLogic;
        public Application(IBusinessLogic businessLogic)
        {
            _businessLogic = businessLogic;
        }

        /// <summary>
        /// use this method to start your application within any static main method
        /// </summary>
        public void Run()
        {
            _businessLogic.ProcessData();
        }
    }
}
