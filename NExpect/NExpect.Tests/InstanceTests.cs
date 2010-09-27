using Microsoft.VisualStudio.TestTools.UnitTesting;
using NExpect.Exceptions;

namespace NExpect.Tests
{
    [TestClass]
    public class InstanceTests
    {
        [TestMethod]
        public void ShouldBeInstanceOf()
        {
            1.Should().Be().Instance().Of<int>();
        }

        [TestMethod, ExpectedException(typeof(ExpectationNotMetException))]
        public void ShouldRaiseExceptionWhenNotInstanceOf()
        {
            1.Should().Be().Instance().Of<string>();
        }

        [TestMethod]
        public void ShouldNotBeInstanceOf()
        {
            1.Should().Not().Be().Instance().Of<string>();
        }

        [TestMethod, ExpectedException(typeof(ExpectationNotMetException))]
        public void ShouldRaiseExceptionWhenInstanceOfNotExpected()
        {
            1.Should().Not().Be().Instance().Of<int>();
        }
    }
}
