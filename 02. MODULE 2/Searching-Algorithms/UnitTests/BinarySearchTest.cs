using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTests
{
    [TestClass]
    public class BinarySearchTest
    {
        [TestMethod]
        public void ShouldReturnTrueIfElementExists()
        {
            SortableCollection.SortableCollection collection = new SortableCollection.SortableCollection(new int[] { 1, 2, 4, 6, 8, 11, 17 });

            Assert.IsTrue(collection.BinarySearch(4));
        }

        [TestMethod]
        public void ShouldReturnFalseIfElementDoesNotExist()
        {
            SortableCollection.SortableCollection collection = new SortableCollection.SortableCollection(new int[] { 1, 2, 4, 6, 8, 11, 17 });

            Assert.IsFalse(collection.BinarySearch(3));
        }
    }
}