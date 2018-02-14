using Autofac;
using FurnitureManufacturer.Injection;
using FurnitureManufacturer.Interfaces.Engine;

namespace FurnitureManufacturer
{
    public class FurnitureProgram
    {
        public static void Main()
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule(new AutofacConfig());

            var container = builder.Build();
            var engine = container.Resolve<IFurnitureManufacturerEngine>();
            engine.Start();
        }
    }
}
