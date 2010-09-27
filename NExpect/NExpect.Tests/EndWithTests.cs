using Microsoft.VisualStudio.TestTools.UnitTesting;
using NExpect.Exceptions;

namespace NExpect.Tests
{
    [TestClass]
    public class EndWithTests
    {
        private const string AString = "abcd";

        [TestMethod]
        public void ShouldEndWith()
        {
            AString.Should().EndWith("cd");
        }

        [TestMethod]
        public void ShouldNotEndWith()
        {
            AString.Should().Not().EndWith("ab");
        }

        [TestMethod, ExpectedException(typeof(ExpectationNotMetException))]
        public void ShouldRaiseExceptionIfDoesNotEndWith()
        {
            AString.Should().EndWith("efgh");
        }

        [TestMethod, ExpectedException(typeof(ExpectationNotMetException))]
        public void ShouldRaiseExceptionIfDoesEndWith()
        {
            AString.Should().Not().EndWith(AString);
        }
    }
}
