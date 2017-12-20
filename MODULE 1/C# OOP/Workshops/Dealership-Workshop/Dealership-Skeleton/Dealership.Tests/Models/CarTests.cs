using Dealership.Contracts;
using Dealership.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Dealership.Tests.Models
{
    [TestClass]
    public class CarTests
    {
        [TestMethod]
        public void Car_Type_ShouldImplementICarInterface()
        {
            var type = typeof(Car);
            var isAssignable = typeof(ICar).IsAssignableFrom(type);

            Assert.IsTrue(isAssignable, "Car class does not implement ICar interface!");
        }

        [TestMethod]
        public void Car_Type_ShouldImplementIVehicleInterface()
        {
            var type = typeof(Car);
            var isAssignable = typeof(IVehicle).IsAssignableFrom(type);

            Assert.IsTrue(isAssignable, "Car class does not implement IVehicle interface!");
        }

        [TestMethod]
        public void Car_Constructor_ShouldThrow_WhenMakeIsNull()
        {
            Assert.ThrowsException<ArgumentNullException>(() => new Car(null, "model", 10, 4));
        }

        [TestMethod]
        public void Car_Constructor_ShouldThrow_WhenMakeLenghtIsBelow2()
        {
            Assert.ThrowsException<ArgumentException>(() => new Car("1", "model", 10, 4));
        }

        [TestMethod]
        public void Car_Constructor_ShouldThrow_WhenMakeLenghtIsAbove15()
        {
            Assert.ThrowsException<ArgumentException>(() => new Car("1234567890123456", "model", 10, 4));
        }


        [TestMethod]
        public void Car_Constructor_ShouldThrow_WhenModelIsNull()
        {
            Assert.ThrowsException<ArgumentNullException>(() => new Car("make", null, 10, 4));
        }

        [TestMethod]
        public void Car_Constructor_ShouldThrow_WhenModelLenghtIsBelow2()
        {
            Assert.ThrowsException<ArgumentException>(() => new Car("make", "", 10, 4));
        }

        [TestMethod]
        public void Car_Constructor_ShouldThrow_WhenModelLenghtIsAbove15()
        {
            Assert.ThrowsException<ArgumentException>(() => new Car("make", "1234567890123456", 10, 4));
        }

        [TestMethod]
        public void Car_Constructor_ShouldThrow_WhenPriceIsNegative()
        {
            Assert.ThrowsException<ArgumentException>(() => new Car("make", "model", -10, 4));
        }

        [TestMethod]
        public void Car_Constructor_ShouldThrow_WhenPriceIsAbove100000()
        {
            Assert.ThrowsException<ArgumentException>(() => new Car("make", "model", 1000001.0m, 4));
        }

        [TestMethod]
        public void Car_Constructor_ShouldThrow_WhenSeatsIsNegative()
        {
            Assert.ThrowsException<ArgumentException>(() => new Car("make", "model", 10, -4));
        }

        [TestMethod]
        public void Car_Constructor_ShouldThrow_WhenSeatsIsAbove10()
        {
            Assert.ThrowsException<ArgumentException>(() => new Car("make", "model", 10, 11));
        }
    }
}
