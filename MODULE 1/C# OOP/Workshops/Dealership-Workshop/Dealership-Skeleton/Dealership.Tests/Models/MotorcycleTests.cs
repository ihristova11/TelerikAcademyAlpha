using Dealership.Contracts;
using Dealership.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Dealership.Tests.Models
{
    [TestClass]
    public class MotorcycleTests
    {
        [TestMethod]
        public void Motorcycle_Type_ShouldImplementIMotorcycleInterface()
        {
            var type = typeof(Motorcycle);
            var isAssignable = typeof(IMotorcycle).IsAssignableFrom(type);

            Assert.IsTrue(isAssignable, "Motorcycle class does not implement IMotorcycle interface!");
        }

        [TestMethod]
        public void Motorcycle_Type_ShouldImplementIVehicleInterface()
        {
            var type = typeof(Motorcycle);
            var isAssignable = typeof(IVehicle).IsAssignableFrom(type);

            Assert.IsTrue(isAssignable, "Motorcycle class does not implement IVehicle interface!");
        }

        [TestMethod]
        public void Motorcycle_Constructor_ShouldThrow_WhenMakeIsNull()
        {
            Assert.ThrowsException<ArgumentNullException>(() => new Motorcycle(null, "model", 10, "category"));
        }

        [TestMethod]
        public void Motorcycle_Constructor_ShouldThrow_WhenMakeLenghtIsBelow2()
        {
            Assert.ThrowsException<ArgumentException>(() => new Motorcycle("1", "model", 10, "category"));
        }

        [TestMethod]
        public void Motorcycle_Constructor_ShouldThrow_WhenMakeLenghtIsAbove15()
        {
            Assert.ThrowsException<ArgumentException>(() => new Motorcycle("1234567890123456", "model", 10, "category"));
        }


        [TestMethod]
        public void Motorcycle_Constructor_ShouldThrow_WhenModelIsNull()
        {
            Assert.ThrowsException<ArgumentNullException>(() => new Motorcycle("make", null, 10, "category"));
        }

        [TestMethod]
        public void Motorcycle_Constructor_ShouldThrow_WhenModelLenghtIsBelow2()
        {
            Assert.ThrowsException<ArgumentException>(() => new Motorcycle("make", "", 10, "category"));
        }

        [TestMethod]
        public void Motorcycle_Constructor_ShouldThrow_WhenModelLenghtIsAbove15()
        {
            Assert.ThrowsException<ArgumentException>(() => new Motorcycle("make", "1234567890123456", 10, "category"));
        }

        [TestMethod]
        public void Motorcycle_Constructor_ShouldThrow_WhenPriceIsNegative()
        {
            Assert.ThrowsException<ArgumentException>(() => new Motorcycle("make", "model", -10, "category"));
        }

        [TestMethod]
        public void Motorcycle_Constructor_ShouldThrow_WhenPriceIsAbove100000()
        {
            Assert.ThrowsException<ArgumentException>(() => new Motorcycle("make", "model", 1000001.0m, "category"));
        }

        [TestMethod]
        public void Motorcycle_Constructor_ShouldThrow_WhenCategoryIsNull()
        {
            Assert.ThrowsException<ArgumentNullException>(() => new Motorcycle("make", "model", 10, null));
        }

        [TestMethod]
        public void Motorcycle_Constructor_ShouldThrow_WhenCategoryLenghtIsBelow1()
        {
            Assert.ThrowsException<ArgumentException>(() => new Motorcycle("make", "model", 10, ""));
        }

        [TestMethod]
        public void Motorcycle_Constructor_ShouldThrow_WhenCategoryLenghtIsAbove10()
        {
            Assert.ThrowsException<ArgumentException>(() => new Motorcycle("make", "model", 10, "12345678901"));
        }
    }
}
