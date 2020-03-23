using Autofac;
using ConsoleUI.Contracts;
using Core.Contracts;
using DemoLibrary;
using DemoLibrary.Utilities;

namespace ConsoleUI.Autofac
{
    /// <summary>
    /// This class manages the autofac dependency injection
    /// </summary>
    public static class ContainerConfig
    {
        /// <summary>
        /// This method configures the autofac container. You can easily exchange its registered types here
        /// </summary>
        /// <returns>A container list key/value of all classes to instanciate defined by its builder</returns>
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<Application>().As<IApplication>();
            builder.RegisterType<BusinessLogic>().As<IBusinessLogic>();

            builder.RegisterType<DataAccess>().As<IDataAccess>();
            builder.RegisterType<ConsoleLogger>().As<ILogger>();

            // if there are alot of little classes this might be exhausting -> therefore use quicker way:
            // within demolibrary find all namespaces that contain the utilities its namespace
            // import all classes and link them with their interfaces that match the pattern I{CLASSNAME}
            // => This gets mapped then
            //builder.RegisterAssemblyTypes(Assembly.Load(nameof(DemoLibrary)))
            //    .Where(t => t.Namespace.Contains("Utilities"))
            //    .As(t => t.GetInterfaces().FirstOrDefault(i => i.Name == "I" + t.Name));
            return builder.Build();
        }


    }
}
