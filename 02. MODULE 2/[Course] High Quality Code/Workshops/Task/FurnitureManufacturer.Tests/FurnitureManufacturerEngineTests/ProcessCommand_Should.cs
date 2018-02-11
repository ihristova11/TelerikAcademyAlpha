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
        public void ExecuteCommand_WhenPassedWithCorrectParam()
        {
            // Arrange
            var commandLine = "somecommand some parameters";
            var commandName = commandLine.Split()[0];
            var commandParams = commandLine.Split().Skip(1).ToList();

            var commandMock = new Mock<ICommand>();

            var rendererStub = new Mock<IRenderer>();
            rendererStub.Setup(x => x.Input()).Returns(new List<string>() { commandLine });

            var factoryStub = new Mock<ICommandFactory>();
            factoryStub.Setup(x => x.GetCommand(commandName)).Returns(commandMock.Object);

            var sut = new FurnitureManufacturerEngine(rendererStub.Object, factoryStub.Object);
            sut.Start();

            // Act & Assert
            commandMock.Verify(x => x.Execute(commandParams), Times.Once);
        }

        [TestMethod]
        public void ReturnCorrectResultFromExecuteCommand_WhenPassedCorrectData()
        {
            // Arrange
            var commandLine = "commandhere some parametershere";
            var commandName = commandLine.Split(' ')[0];
            var commandParams = commandLine.Split(' ').Skip(1).ToList();
            var commandReturnMessage = "Command executed successfully!";

            var rendererMock = new Mock<IRenderer>();
            rendererMock.Setup(x => x.Input()).Returns(new List<string>() { commandLine });
            
            var commandStub = new Mock<ICommand>();
            commandStub.Setup(x => x.Execute(commandParams)).Returns(commandReturnMessage);

            var factoryStub = new Mock<ICommandFactory>();
            factoryStub.Setup(x => x.GetCommand(commandName)).Returns(commandStub.Object);

            var sut = new FurnitureManufacturerEngine(rendererMock.Object, factoryStub.Object);
            sut.Start();

            var output = new List<string>(){commandReturnMessage};

            // Act & Assert
            rendererMock.Verify(x=>x.Output(output), Times.Once);
        }

        [TestMethod]
        public void CallCreateCommandFactory_WithCorrectCommandName()
        {
            // Arrange
            var commandLine = "some command parameters";
            var commandName = commandLine.Split(' ')[0];

            var factoryMock = new Mock<ICommandFactory>();
            var rendererStub = new Mock<IRenderer>();
            rendererStub.Setup(x => x.Input()).Returns(new List<string>() {commandLine});

            var sut = new FurnitureManufacturerEngine(rendererStub.Object, factoryMock.Object);
            sut.Start();
            
            // Act & Assert
            factoryMock.Verify(x=>x.GetCommand(commandName), Times.Once);
        }
    }
}
