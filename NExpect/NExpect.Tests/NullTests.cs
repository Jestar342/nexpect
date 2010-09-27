using Microsoft.VisualStudio.TestTools.UnitTesting;
using NExpect.Exceptions;

namespace NExpect.Tests
{
    [TestClass]
    public class NullTests
    {
        private readonly object _null;

        [TestMethod]
        public void ShouldBeNull()
        {
            _null.Should().Be().Null();
        }

        [TestMethod]
        public void ShouldNotBeNull()
        {
            1.Should().Not().Be().Null();
        }

        [TestMethod, ExpectedException(typeof (ExpectationNotMetException))]
        public void ShouldRaiseExceptionWhenNotNullAndExpectedToBeNull()
        {
            1.Should().Be().Null();
        }

        [TestMethod, ExpectedException(typeof (ExpectationNotMetException))]
        public void ShouldRaiseExceptionWhenNullAndExpectedToBeNotNull()
        {
            _null.Should().Not().Be().Null();
        }
    }
}