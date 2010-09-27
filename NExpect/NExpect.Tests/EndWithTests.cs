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
            AString.Should().End().With("cd");
        }

        [TestMethod]
        public void ShouldNotEndWith()
        {
            AString.Should().Not().End().With("ab");
        }

        [TestMethod, ExpectedException(typeof(ExpectationNotMetException))]
        public void ShouldRaiseExceptionIfDoesNotEndWith()
        {
            AString.Should().End().With("efgh");
        }

        [TestMethod, ExpectedException(typeof(ExpectationNotMetException))]
        public void ShouldRaiseExceptionIfDoesEndWith()
        {
            AString.Should().Not().End().With(AString);
        }
    }
}
