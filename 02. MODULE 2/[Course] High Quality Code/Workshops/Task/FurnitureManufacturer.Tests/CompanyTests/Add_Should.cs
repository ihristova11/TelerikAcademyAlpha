using System;
using FurnitureManufacturer.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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


    }
}
