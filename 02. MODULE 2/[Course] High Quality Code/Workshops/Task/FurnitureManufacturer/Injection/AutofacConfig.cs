using System.Reflection;
using Autofac;
using FurnitureManufacturer.Engine;
using FurnitureManufacturer.Engine.Commands;
using FurnitureManufacturer.Engine.Commands.CompanyCommands;
using FurnitureManufacturer.Engine.Factories;
using FurnitureManufacturer.Interfaces.Engine;
using ICommand = FurnitureManufacturer.Engine.Commands.Contracts.ICommand;
using Module = Autofac.Module;

namespace FurnitureManufacturer.Injection
{
    public class AutofacConfig : Module
    {
        protected override void Load(ContainerBuilder containerBuilder)
        {
            var currentAssembly = Assembly.GetExecutingAssembly();

            containerBuilder.RegisterAssemblyTypes(currentAssembly)
                .AsImplementedInterfaces();

            containerBuilder.RegisterType<ConsoleRenderer>().As<IRenderer>().SingleInstance();
            containerBuilder.RegisterType<DataStore>().As<IDataStore>()
                .SingleInstance();

            containerBuilder.RegisterType<CommandFactory>().As<ICommandFactory>()
                .SingleInstance();
            containerBuilder.RegisterType<FurnitureFactory>().As<IFurnitureFactory>()
                .SingleInstance();
            containerBuilder.RegisterType<CompanyFactory>().As<ICompanyFactory>()
                .SingleInstance();

            containerBuilder.RegisterType<CreateChairCommand>().Named<ICommand>("createchair");
            containerBuilder.RegisterType<CreateCompanyCommand>().Named<ICommand>("createcompany");
            containerBuilder.RegisterType<CreateTableCommand>().Named<ICommand>("createtable");
            containerBuilder.RegisterType<AddFurnitureToCompanyCommand>().Named<ICommand>("addfurnituretocompany");
            containerBuilder.RegisterType<FindFurnitureFromCompanyCommand>().Named<ICommand>("findfurniturefromcompany");
            containerBuilder.RegisterType<RemoveFurnitureFromCompanyCommand>().Named<ICommand>("removefurniturefromcompany");
            containerBuilder.RegisterType<ShowCompanyCatalogCommand>().Named<ICommand>("showcompanycatalog");

            containerBuilder.RegisterType<FurnitureManufacturerEngine>().As<IFurnitureManufacturerEngine>()
            .SingleInstance();
        }
    }
}
