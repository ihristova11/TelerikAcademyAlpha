using System;
using System.Collections.Generic;
using System.Linq;
using Agency.Core.Contracts;
using Agency.Core.Factories;
using Agency.Models.Contracts;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Traveller.Commands.Creating;

namespace Agency.Tests.Commands.CreateTicketCommandTests
{
    [TestClass]
    public class Execute_Should
    {
        [TestMethod]
        public void ThrowArgumentException_WhenJourneyIsNull()
        {
            // Arrange
            var commandParametersList = new List<string>();
            commandParametersList.Add(null);
            commandParametersList.Add("100");
            var dataStoreMock = new Mock<IDataStore>();
            var ticketFactoryMock = new Mock<ITicketFactory>();

            var sut = new CreateTicketCommand(ticketFactoryMock.Object, dataStoreMock.Object);

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => sut.Execute(commandParametersList));
        }

        [TestMethod]
        public void ThrowArgumentException_WhenAdministrativeCostsAreNull()
        {
            // Arrange
            var commandParametersList = new List<string>();
            commandParametersList.Add("1");
            commandParametersList.Add(null);
            var dataStoreMock = new Mock<IDataStore>();
            var ticketFactoryMock = new Mock<ITicketFactory>();

            var sut = new CreateTicketCommand(ticketFactoryMock.Object, dataStoreMock.Object);

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => sut.Execute(commandParametersList));
        }

        [TestMethod]
        public void ReturnsProperMessage_WhenInvokedWithProperParams()
        {
            // Arrange
            var commandParametersList = "createticket 0 30".Split(' ').Skip(1).ToList();
            var expected = "Ticket with ID 0 was created.";
            var journeyMock = new Mock<IJourney>();
            var dataStoreMock = new Mock<IDataStore>();
            dataStoreMock.Setup(x => x.Journeys[0]).Returns(journeyMock.Object);
            dataStoreMock.Setup(x => x.Tickets).Returns(new List<ITicket>());
            var ticketFactoryMock = new Mock<ITicketFactory>();

            var sut = new CreateTicketCommand(ticketFactoryMock.Object, dataStoreMock.Object);

            // Act 
            var actual = sut.Execute(commandParametersList);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ThrowArgumentException_WhenSuchJourneyDoesNotExist()
        {
            // Arrange
            var commandParametersList = "createticket 1 100".Split(' ').Skip(1).ToList();
            var expected = "Ticket with ID 0 was created.";
            var dataStoreMock = new Mock<IDataStore>();
            dataStoreMock.Setup(x => x.Journeys).Returns(new List<IJourney>());
            dataStoreMock.Setup(x => x.Tickets).Returns(new List<ITicket>());

            var ticketFactoryMock = new Mock<ITicketFactory>();

            var sut = new CreateTicketCommand(ticketFactoryMock.Object, dataStoreMock.Object);

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => sut.Execute(commandParametersList));
        }

        [TestMethod]
        public void CallFactoryCreateTicket_WhenPassedCorrectParams()
        {
            // Arrange
            var commandParametersList = "createticket 0 30".Split(' ').Skip(1).ToList();
            var expected = "Ticket with ID 0 was created.";
            var journeyMock = new Mock<IJourney>();
            var dataStoreMock = new Mock<IDataStore>();
            dataStoreMock.Setup(x => x.Journeys[0]).Returns(journeyMock.Object);
            dataStoreMock.Setup(x => x.Tickets).Returns(new List<ITicket>());
            var ticketFactoryMock = new Mock<ITicketFactory>();
            var administrativeCosts = 30m;
            
            var sut = new CreateTicketCommand(ticketFactoryMock.Object, dataStoreMock.Object);

            // Act
            sut.Execute(commandParametersList);

            // Assert
            ticketFactoryMock.Verify(x=>x.CreateTicket(journeyMock.Object, administrativeCosts));
        }
    }
}
