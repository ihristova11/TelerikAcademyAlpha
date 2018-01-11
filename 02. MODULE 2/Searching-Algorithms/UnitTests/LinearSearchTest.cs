using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTests
{
    [TestClass]
    public class LinearSearchTest
    {
        [TestMethod]
        public void ShouldReturnTrueIfElementExists()
        {
            SortableCollection.SortableCollection collection = new SortableCollection.SortableCollection(new int[]{ 1, 5, 4, 2, 7, -1, 0 });

            Assert.IsTrue(collection.LinearSearch(4));
        }

        [TestMethod]
        public void ShouldReturnFalseIfElementDoesNotExist()
        {
            SortableCollection.SortableCollection collection = new SortableCollection.SortableCollection(new int[] { 1, 5, 4, 2, 7, -1, 0 });

            Assert.IsFalse(collection.LinearSearch(3));
        }
    }
}
