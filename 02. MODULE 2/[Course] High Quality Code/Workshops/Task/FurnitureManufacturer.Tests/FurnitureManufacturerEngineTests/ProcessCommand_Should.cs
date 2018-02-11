using System.Collections.Generic;
using System.Linq;
using FurnitureManufacturer.Engine;
using FurnitureManufacturer.Interfaces.Engine;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using ICommand = FurnitureManufacturer.Engine.Commands.Contracts.ICommand;

namespace FurnitureManufacturer.Tests.FurnitureManufacturerEngineTests
{
    [TestClass]
    public class ProcessCommand_Should
    {
        [TestMethod]
        public void CallExecuteMethod_WhenPassedWithCorrectParam()
        {
            var commandLine = "somecommand some parameters";
            var commandName = commandLine.Split()[0];
            var commandParams = commandLine.Split().Skip(1).ToList();

            var rendererStub = new Mock<IRenderer>();
            rendererStub.Setup(x => x.Input()).Returns(new List<string>() { commandLine });

            var commandMock = new Mock<ICommand>();
            var factoryStub = new Mock<ICommandFactory>();
            factoryStub.Setup(x => x.GetCommand(commandName)).Returns(commandMock.Object);

            var sut = new FurnitureManufacturerEngine(rendererStub.Object, factoryStub.Object);
            sut.Start();

            commandMock.Verify(x => x.Execute(commandParams), Times.Once);
        }
    }
}
