using Dealership.Contracts;
using Dealership.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Dealership.Tests.Models
{
    [TestClass]
    public class CommentTests
    {
        [TestMethod]
        public void Comment_Type_ShouldImplementICommentInterface()
        {
            var type = typeof(Comment);
            var isAssignable = typeof(IComment).IsAssignableFrom(type);

            Assert.IsTrue(isAssignable, "Comment class does not implement IComment interface!");
        }

        [TestMethod]
        public void Comment_Constructor_ShouldThrow_WhenContentIsNull()
        {
            Assert.ThrowsException<ArgumentNullException>(() => new Comment(null));
        }        
    }
}
