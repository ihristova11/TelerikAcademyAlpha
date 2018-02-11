
using System.Reflection;
using Autofac;
using FurnitureManufacturer.Engine;
using FurnitureManufacturer.Engine.Commands;
using FurnitureManufacturer.Engine.Commands.Contracts;
using FurnitureManufacturer.Engine.Commands.CompanyCommands;
using FurnitureManufacturer.Engine.Factories;
using FurnitureManufacturer.Interfaces.Engine;
using ICommand = FurnitureManufacturer.Engine.Commands.Contracts;
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

            containerBuilder.RegisterType<CreateChairCommand>().Named<Engine.Commands.Contracts.ICommand>("createchair");
            containerBuilder.RegisterType<CreateCompanyCommand>().Named<ICommand.ICommand>("createcompany");
            containerBuilder.RegisterType<CreateTableCommand>().Named<ICommand.ICommand>("createtable");
            containerBuilder.RegisterType<AddFurnitureToCompanyCommand>().Named<ICommand.ICommand>("addfurnituretocompany");
            containerBuilder.RegisterType<FindFurnitureFromCompanyCommand>().Named<ICommand.ICommand>("findfurniturefromcompany");
            containerBuilder.RegisterType<RemoveFurnitureFromCompanyCommand>().Named<ICommand.ICommand>("removefurniturefromcompany");
            containerBuilder.RegisterType<ShowCompanyCatalogCommand>().Named<ICommand.ICommand>("showcompanycatalog");

            containerBuilder.RegisterType<FurnitureManufacturerEngine>().As<IFurnitureManufacturerEngine>()
            .SingleInstance();
        }
    }
}
