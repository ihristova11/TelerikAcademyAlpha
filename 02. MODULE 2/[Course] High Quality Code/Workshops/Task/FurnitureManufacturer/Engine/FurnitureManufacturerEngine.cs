using FurnitureManufacturer.Interfaces.Engine;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FurnitureManufacturer.Engine
{
    public sealed class FurnitureManufacturerEngine : IFurnitureManufacturerEngine
    {
        private readonly ICommandFactory commandFactory;
        private readonly IRenderer renderer;

        public FurnitureManufacturerEngine(ICommandFactory commandFactory, IRenderer renderer)
        {
            this.commandFactory = commandFactory;
            this.renderer = renderer;
        }

        public void Start()
        {
            var commandResults = new List<string>();

            try
            {
                foreach (var line in this.renderer.Input())
                {
                    commandResults.Add(this.ProcessCommands(line));
                }
            }
            catch (Exception ex)
            {
                commandResults.Add(ex.Message);
            }
            
            this.renderer.Output(commandResults);
        }
        
        private string ProcessCommands(string commandLine)
        {
            var commandParts = commandLine.Split(' ').ToList();
            var commandName = commandParts[0];
            var commandParameters = commandParts.Skip(1).ToList();

            var command = this.commandFactory.GetCommand(commandName);
            return command.Execute(commandParameters);
        }
    }
}
