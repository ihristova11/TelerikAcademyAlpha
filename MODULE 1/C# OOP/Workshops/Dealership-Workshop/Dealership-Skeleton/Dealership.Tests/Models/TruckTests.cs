using Dealership.Contracts;
using Dealership.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Dealership.Tests.Models
{
    [TestClass]
    public class TruckTests
    {
        [TestMethod]
        public void Truck_Type_ShouldImplementITruckInterface()
        {
            var type = typeof(Truck);
            var isAssignable = typeof(ITruck).IsAssignableFrom(type);

            Assert.IsTrue(isAssignable, "Truck class does not implement ITruck interface!");
        }

        [TestMethod]
        public void Truck_Type_ShouldImplementIVehicleInterface()
        {
            var type = typeof(Truck);
            var isAssignable = typeof(IVehicle).IsAssignableFrom(type);

            Assert.IsTrue(isAssignable, "Truck class does not implement IVehicle interface!");
        }

        [TestMethod]
        public void Truck_Constructor_ShouldThrow_WhenMakeIsNull()
        {
            Assert.ThrowsException<ArgumentNullException>(() => new Truck(null, "model", 10, 10));
        }

        [TestMethod]
        public void Truck_Constructor_ShouldThrow_WhenMakeLenghtIsBelow2()
        {
            Assert.ThrowsException<ArgumentException>(() => new Truck("1", "model", 10, 10));
        }

        [TestMethod]
        public void Truck_Constructor_ShouldThrow_WhenMakeLenghtIsAbove15()
        {
            Assert.ThrowsException<ArgumentException>(() => new Truck("1234567890123456", "model", 10, 10));
        }


        [TestMethod]
        public void Truck_Constructor_ShouldThrow_WhenModelIsNull()
        {
            Assert.ThrowsException<ArgumentNullException>(() => new Truck("make", null, 10, 10));
        }

        [TestMethod]
        public void Truck_Constructor_ShouldThrow_WhenModelLenghtIsBelow2()
        {
            Assert.ThrowsException<ArgumentException>(() => new Truck("make", "", 10, 10));
        }

        [TestMethod]
        public void Truck_Constructor_ShouldThrow_WhenModelLenghtIsAbove15()
        {
            Assert.ThrowsException<ArgumentException>(() => new Truck("make", "1234567890123456", 10, 10));
        }

        [TestMethod]
        public void Truck_Constructor_ShouldThrow_WhenPriceIsNegative()
        {
            Assert.ThrowsException<ArgumentException>(() => new Truck("make", "model", -10, 10));
        }

        [TestMethod]
        public void Truck_Constructor_ShouldThrow_WhenPriceIsAbove100000()
        {
            Assert.ThrowsException<ArgumentException>(() => new Truck("make", "model", 1000001.0m, 10));
        }

        [TestMethod]
        public void Truck_Constructor_ShouldThrow_WhenWeightCapacityIsNegative()
        {
            Assert.ThrowsException<ArgumentException>(() => new Truck("make", "model", 10, -10));
        }

        [TestMethod]
        public void Truck_Constructor_ShouldThrow_WhenWeightCapacityIsAbove100()
        {
            Assert.ThrowsException<ArgumentException>(() => new Truck("make", "model", 10, 101));
        }
    }
}
