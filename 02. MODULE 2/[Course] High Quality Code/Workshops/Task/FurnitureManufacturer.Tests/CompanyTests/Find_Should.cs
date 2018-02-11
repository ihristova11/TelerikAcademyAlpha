using System;
using FurnitureManufacturer.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
            var model = "model";
            string name = "somecompanynamehere";
            string registrationNumber = "1234567899";

            var sut = new Company(name, registrationNumber);

            Assert.IsTrue(null == sut.Find(model));
        }
    }
}
