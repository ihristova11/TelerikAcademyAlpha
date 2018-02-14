using System;
using FurnitureManufacturer.Interfaces;
using FurnitureManufacturer.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace FurnitureManufacturer.Tests.CompanyTests
{
    [TestClass]
    public class Find_Should
    {
        [TestMethod]
        public void ThrowArgumentNullException_WhenCompanyModelIsNull()
        {
            // Arrange
            string name = "somecompanynamehere";
            string registrationNumber = "1234567899";
            string model = null;

            var sut = new Company(name, registrationNumber);

            // Act & Assert
            Assert.ThrowsException<ArgumentNullException>(() => sut.Find(model));
        }

        [TestMethod]
        public void ReturnNull_IfFurnitureNotFound()
        {
            // Arrange
            var model = "model";
            string name = "somecompanynamehere";
            string registrationNumber = "1234567899";

            var sut = new Company(name, registrationNumber);

            // Act & Assert
            Assert.IsTrue(null == sut.Find(model));
        }

        [TestMethod]
        public void ReturnFurniture_WhenThereIsSuchInCollection()
        {
            // Arrange
            var model = "model";
            string name = "somecompanynamehere";
            string registrationNumber = "1234567899";
            var furnitureStub = new Mock<IFurniture>();
            furnitureStub.Setup(x => x.Model).Returns(model);
            var sut = new Company(name, registrationNumber);
            sut.Furnitures.Clear();
            sut.Furnitures.Add(furnitureStub.Object);

            // Act
            var result = sut.Find(model);

            // Assert
            Assert.AreSame(furnitureStub.Object, result);
        }
    }
}
