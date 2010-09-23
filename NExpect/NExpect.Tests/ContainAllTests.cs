using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NExpect.Tests
{
    [TestClass]
    public class ContainAllTests
    {
        [TestMethod]
        public void ShouldContainAll()
        {
            var listA = new List<int> {1, 2, 3, 4};
            var listB = new List<int> {1, 2, 3, 4};

            listA.Should().Contain().All(listB);
        }

        [TestMethod]
        public void ShouldContainAllInArray()
        {
            var arrayA = new[] {1, 2, 3, 4};
            var arrayB = new[] {1, 2, 3, 4};

            arrayA.Should().Contain().All(arrayB);
        }

        [TestMethod]
        public void ShouldNotContainAll()
        {
            var arrayA = new[] {1, 2, 3, 4};
            var arrayB = new[] {5, 6, 7, 8};

            arrayA.Should().Not().Contain().All(arrayB);
        }
    }
}