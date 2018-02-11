using System.Reflection;
using Agency.Commands.Contracts;
using Agency.Commands.Creating;
using Agency.Core;
using Agency.Core.Contracts;
using Agency.Core.Providers.Decorators;
using Autofac;
using Traveller.Commands.Creating;
using Module = Autofac.Module;

namespace Agency.Injection
{
    public class AutofacConfing : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var currentAssembly = Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(currentAssembly)
                .AsImplementedInterfaces();

            builder.RegisterType<DataStore>().As<IDataStore>().SingleInstance();

            builder.RegisterType<CreateAirplaneCommand>().Named<ICommand>("createairplane");
            builder.RegisterType<CreateBusCommand>().Named<ICommand>("createbus");
            builder.RegisterType<CreateTrainCommand>().Named<ICommand>("createtrain");
            builder.RegisterType<CreateJourneyCommand>().Named<ICommand>("createjourney");
            builder.RegisterType<CreateTicketCommand>().Named<ICommand>("createticket");
            builder.RegisterType<ListJourneysCommand>().Named<ICommand>("listjourneys");
            builder.RegisterType<ListTicketsCommand>().Named<ICommand>("listtickets");
            builder.RegisterType<ListVehiclesCommand>().Named<ICommand>("listvehicles");
            builder.RegisterType<Engine>().As<IEngine>().SingleInstance();
            builder.RegisterType<EngineDecorator>().AsSelf().SingleInstance();
        }
    }
}
