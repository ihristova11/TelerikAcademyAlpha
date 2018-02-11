using System.Reflection;
using Autofac;
using FurnitureManufacturer.Engine;
using FurnitureManufacturer.Interfaces.Engine;

namespace FurnitureManufacturer
{
    public sealed class AutoFacConfig
    {
        public IContainer Build()
        {
            var containerBuilder = new ContainerBuilder();

            this.RegisterConvention(containerBuilder);
            this.RegisterCoreComponents(containerBuilder);

            return containerBuilder.Build();
        }

        private void RegisterConvention(ContainerBuilder builder)
        {
            var coreAssembly = Assembly.GetEntryAssembly();

            builder.RegisterAssemblyTypes(coreAssembly)
                .AsImplementedInterfaces();
        }

        private void RegisterCoreComponents(ContainerBuilder builder)
        {
            builder.RegisterType<FurnitureManufacturerEngine>()
                .As<IFurnitureManufacturerEngine>()
                .SingleInstance();
        }
    }
}
