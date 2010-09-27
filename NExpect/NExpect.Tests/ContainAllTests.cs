using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NExpect.Exceptions;

namespace NExpect.Tests
{
    [TestClass]
    public class ContainAllTests
    {
        [TestMethod]
        public void ShouldContainAll()
        {
            var listA = new List<int> { 1, 2, 3, 4 };
            var listB = new List<int> { 1, 2, 3, 4 };

            listA.Should().Contain().All(listB);
        }

        [TestMethod]
        public void ShouldContainAllInArray()
        {
            arrayA.Should().Contain().All((Array) arrayA.Clone());
        }

        [TestMethod]
        public void ShouldNotContainAll()
        {
            arrayA.Should().Not.Contain().All(arrayB);
        }

        [TestMethod, ExpectedException(typeof (ExpectationNotMetException))]
        public void ShouldRaiseExceptionWhenDoesContainAll()
        {
            arrayA.Should().Not.Contain().All((Array) arrayA.Clone());
        }

        [TestMethod, ExpectedException(typeof (ExpectationNotMetException))]
        public void ShouldRaiseExceptionWhenDoesntContainAll()
        {
            arrayA.Should().Contain().All(arrayB);
        }

        private readonly int[] arrayA = new[] { 1, 2, 3, 4 };
        private readonly int[] arrayB = new[] { 5, 6, 7, 8 };
    }
}