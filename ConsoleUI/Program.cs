using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using ConsoleUI.Autofac;
using ConsoleUI.Contracts;
using Core.Contracts;

namespace ConsoleUI
{
    class Program
    {
        /// <summary>
        /// Getting instances from container config. BUT Main is a static class -> cannot be instanciated and it is required coze passed via constructor
        /// BUT main-entrypoint of program shall be within autofac as well. Deshalb: create a new Class/Interface called Application
        /// BIG Advantage: TESTING the application decoupled! -> MOCKING is possible for each sub-dependency
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Create Factory or primary Autofac to create instances and wire it up using the ContainerConfig
            // This configures the container that is holding all our design for instanciating data and classes
            var container = ContainerConfig.Configure();

            // setting a new scope for instances that are passed out / created. //(typically)
            using (var scope = container.BeginLifetimeScope())
            {
                var app = scope.Resolve<IApplication>();
                app.Run();
            }


            Console.ReadLine();
        }
    }
}
