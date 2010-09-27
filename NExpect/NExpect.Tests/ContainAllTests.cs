using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NExpect.Exceptions;

namespace NExpect.Tests
{
    [TestClass]
    public class ContainAllTests
    {
        private readonly int[] _arrayA = new[] {1, 2, 3, 4};
        private readonly int[] _arrayB = new[] {5, 6, 7, 8};

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
            _arrayA.Should().Contain().All((Array) _arrayA.Clone());
        }

        [TestMethod]
        public void ShouldNotContainAll()
        {
            _arrayA.Should().Not().Contain().All(_arrayB);
        }

        [TestMethod, ExpectedException(typeof (ExpectationNotMetException))]
        public void ShouldRaiseExceptionWhenDoesntContainAll()
        {
            _arrayA.Should().Contain().All(_arrayB);
        }

        [TestMethod, ExpectedException(typeof (ExpectationNotMetException))]
        public void ShouldRaiseExceptionWhenDoesContainAll()
        {
            _arrayA.Should().Not().Contain().All((Array) _arrayA.Clone());
        }
    }
}