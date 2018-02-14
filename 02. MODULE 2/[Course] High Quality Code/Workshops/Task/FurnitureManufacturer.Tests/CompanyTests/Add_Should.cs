using System;
using FurnitureManufacturer.Interfaces;
using FurnitureManufacturer.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace FurnitureManufacturer.Tests.CompanyTests
{
    [TestClass]
    public class Add_Should
    {
        [TestMethod]
        public void ThrowArgumentNullException_WhenFurnitureIsNull()
        {
            // Arrange
            var companyName = "somecompanyname";
            var registrationNumber = "1234567890";

            var sut = new Company(companyName, registrationNumber);

            // Act & Assert
            Assert.ThrowsException<ArgumentNullException>(() => sut.Add(null));
        }

        [TestMethod]
        public void AddFurnitureToCollection_WhenPassedCorrectData()
        {
            // Arrange
            var companyName = "somecompanynamehere";
            var registrationNumber = "1234567890";
            var furnitureStub = new Mock<IFurniture>();
            var sut = new Company(companyName, registrationNumber);

            // Act
            sut.Add(furnitureStub.Object);

            // Assert
            Assert.IsTrue(sut.Furnitures.Count == 1);
        }
    }
}
