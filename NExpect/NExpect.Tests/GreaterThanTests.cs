using Microsoft.VisualStudio.TestTools.UnitTesting;
using NExpect.Exceptions;

namespace NExpect.Tests
{
    [TestClass]
    public class GreaterThanTests
    {
        [TestMethod]
        public void ShouldBeGreaterThan()
        {
            2.Should().Be.Greater.Than(1);
        }

        [TestMethod, ExpectedException(typeof(ExpectationNotMetException))]
        public void ShouldRaiseExceptionIfNotGreaterThan()
        {
            1.Should().Be.Greater.Than(2);
        }

        [TestMethod]
        public void ShouldNotBeGreaterThan()
        {
            1.Should().Not.Be.Greater.Than(2);
        }

        [TestMethod, ExpectedException(typeof(ExpectationNotMetException))]
        public void ShouldRaiseExceptionIfGreaterThanNotExpected()
        {
            2.Should().Not.Be.Greater.Than(1);
        }
    }
}
