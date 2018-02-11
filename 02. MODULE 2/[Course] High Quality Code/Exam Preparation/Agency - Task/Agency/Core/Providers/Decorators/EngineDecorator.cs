using System.Diagnostics;
using Agency.Core.Contracts;

namespace Agency.Core.Providers.Decorators
{
    public class EngineDecorator : IEngine
    {
        private readonly IEngine engine;
        private readonly IWriter writer;

        public EngineDecorator(IEngine engine, IWriter writer)
        {
            this.engine = engine;
            this.writer = writer;
        }

        public void Start()
        {
            this.writer.WriteLine("The Engine started working...");

            var watch = Stopwatch.StartNew();
            this.engine.Start();
            watch.Stop();
            var milliseconds = watch.ElapsedMilliseconds;

            this.writer.WriteLine($"The Engine worked for {milliseconds} milliseconds.");
        }
    }
}
