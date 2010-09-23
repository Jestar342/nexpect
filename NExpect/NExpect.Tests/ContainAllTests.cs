using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NExpect.Tests
{
    [TestClass]
    public class ContainAllTests
    {
        [TestMethod]
        public void ShouldHaveSameElements()
        {
            var listA = new List<int> {1, 2, 3, 4};
            var listB = new List<int> {1, 2, 3, 4};

            listA.Should().Contain().All(listB);
        }
    }
}