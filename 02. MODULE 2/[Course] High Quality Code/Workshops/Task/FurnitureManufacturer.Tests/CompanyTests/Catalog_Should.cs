using FurnitureManufacturer.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FurnitureManufacturer.Tests.CompanyTests
{
    [TestClass]
    public class Catalog_Should
    {
        [TestMethod]
        public void ReturnProperMessage_WhenFurnitureCollectionIsEmpty()
        {
            var name = "FurnitureTelerik";
            var registrationNumber = "1234567890";
            var expected = "FurnitureTelerik - 1234567890 - no furnitures";
            var sut = new Company(name, registrationNumber);

            var actual = sut.Catalog();
            
            Assert.AreEqual(expected, actual);
        }
    }
}
