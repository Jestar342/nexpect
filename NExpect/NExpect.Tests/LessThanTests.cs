using Microsoft.VisualStudio.TestTools.UnitTesting;
using NExpect.Exceptions;

namespace NExpect.Tests
{
    [TestClass]
    public class LessThanTests
    {
        [TestMethod]
        public void ShouldBeLessThan()
        {
            1.Should().Be.Less.Than(2);
        }

        [TestMethod, ExpectedException(typeof(ExpectationNotMetException))]
        public void ShouldRaiseExceptionWhenNotLessThan()
        {
            2.Should().Be.Less.Than(1);
        }

        [TestMethod]
        public void ShouldNotBeLessThan()
        {
            2.Should().Not.Be.Less.Than(1);
        }

        [TestMethod, ExpectedException(typeof(ExpectationNotMetException))]
        public void ShouldRaiseExceptionWhenLessThanNotExpected()
        {
            1.Should().Not.Be.Less.Than(2);
        }
    }
}
