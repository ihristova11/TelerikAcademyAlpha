using Agency.Commands.Contracts;
using Agency.Core.Factories;
using Agency.Core.Providers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Agency.Tests.Core.Providers.CommandParserTests
{
    [TestClass]
    public class ParseCommand_Should
    {
        [TestMethod]
        public void CallFactory_WhenCorrectParamsPassed()
        {
            string commandLine = "createairplane 100 1 true";
            var commandName = commandLine.Split(' ')[0];
            var commandFactoryMock = new Mock<ICommandFactory>();

            var sut = new CommandParser(commandFactoryMock.Object);
            sut.ParseCommand(commandLine);
            
            commandFactoryMock.Verify(x => x.GetCommand(commandName));
        }

        [TestMethod]
        public void ReturnProperCommand_WhenPassedProperParams()
        {
            string commandLine = "createairplane 100 1 true";
            var commandName = commandLine.Split(' ')[0];
            var commandMock = new Mock<ICommand>();
            var commandFactoryMock = new Mock<ICommandFactory>();
            commandFactoryMock.Setup(x => x.GetCommand(commandName)).Returns(commandMock.Object);

            var sut = new CommandParser(commandFactoryMock.Object);
            var returned = sut.ParseCommand(commandLine);

            Assert.AreEqual(commandMock.Object, returned);
        }
    }
}
