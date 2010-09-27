using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NExpect.Exceptions;

namespace NExpect.Tests
{
    [TestClass]
    public class EmptyTests
    {
        private readonly List<int> _emptyList = new List<int>();
        private readonly List<int> _notEmptyList = new List<int> { 1 };

        [TestMethod]
        public void ShouldBeEmpty()
        {
            _emptyList.Should().Be.Empty();
        }

        [TestMethod]
        public void ShouldNotBeEmpty()
        {
            _notEmptyList.Should().Not.Be.Empty();
        }

        [TestMethod, ExpectedException(typeof(ExpectationNotMetException))]
        public void ShouldRaiseExceptionWhenNotEmptyAndExpectedToBeEmpty()
        {
            _notEmptyList.Should().Be.Empty();
        }

        [TestMethod, ExpectedException(typeof(ExpectationNotMetException))]
        public void ShouldRaiseExceptionWhenEmptyAndExpectedToNotBeEmpty()
        {
            _emptyList.Should().Not.Be.Empty();
        }
    }
}
