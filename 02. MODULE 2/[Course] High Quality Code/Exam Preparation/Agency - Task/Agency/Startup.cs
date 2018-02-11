using Agency.Core;
using Agency.Core.Contracts;
using Agency.Core.Providers.Decorators;
using Agency.Injection;
using Autofac;

namespace Agency
{
    public class Startup
    {
        public static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule(new AutofacConfing());
            var container = builder.Build();
            var engine = container.Resolve<EngineDecorator>();
            engine.Start();
        }
    }
}
