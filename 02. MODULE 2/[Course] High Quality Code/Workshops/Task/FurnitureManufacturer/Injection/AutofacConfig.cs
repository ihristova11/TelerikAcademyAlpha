using System.Reflection;
using Autofac;
using FurnitureManufacturer.Engine;
using FurnitureManufacturer.Interfaces.Engine;
using Module = Autofac.Module;

namespace FurnitureManufacturer.Injection
{
    public class AutofacConfig : Module
    {
        public void Load(ContainerBuilder containerBuilder)
        {
            var currentAssembly = Assembly.GetExecutingAssembly();

            containerBuilder.RegisterAssemblyTypes(currentAssembly)
                .AsImplementedInterfaces();

            containerBuilder.RegisterType<FurnitureManufacturerEngine>().As<IFurnitureManufacturerEngine>()
                .SingleInstance();

            containerBuilder.RegisterType<ConsoleRenderer>().As<IRenderer>().SingleInstance();
        }
    }
}
