using Agency.Core.Factories;
using Agency.Core.Providers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Agency.Tests.Core.Providers.CommandParserTests
{
    [TestClass]
    public class ParseParameters_Should
    {
        [TestMethod]
        public void ReturnEmptyList_WhenNoParametersPassed()
        {
            var commandLine = "somecommand";
            var commandFactoryStub = new Mock<ICommandFactory>();

            var sut = new CommandParser(commandFactoryStub.Object);
            var returned = sut.ParseParameters(commandLine);

            Assert.IsTrue(returned.Count == 0);
        }

        [TestMethod]
        public void ReturnListWithCorrectNumberOfParams_WhenSuchPassed()
        {
            var commandLine = "somecommand 0 30";
            var commandFactoryStub = new Mock<ICommandFactory>();

            var sut = new CommandParser(commandFactoryStub.Object);
            var returned = sut.ParseParameters(commandLine);

            Assert.IsTrue(returned.Count == 2);
        }

        [TestMethod]
        public void ReturnsListWithCorrectParams_WhenSuchPassed()
        {
            var commandLine = "somecommand 0 30";
            var commandFactoryStub = new Mock<ICommandFactory>();

            var sut = new CommandParser(commandFactoryStub.Object);
            var returned = sut.ParseParameters(commandLine);

            Assert.IsTrue(returned.Contains("0") && returned.Contains("30"));
        }
    }
}
