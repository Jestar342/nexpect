using Microsoft.VisualStudio.TestTools.UnitTesting;
using NExpect.Exceptions;

namespace NExpect.Tests
{
    [TestClass]
    public class StartWithTests
    {
        private const string AString = "1234";
        private readonly int[] _arrayA = new[] {1, 2, 3, 4};
        private readonly int[] _arrayB = new[] {1, 2, 3, 4};

        [TestMethod]
        public void ShouldStartWith()
        {
            AString.Should().Start().With("12");
        }

        [TestMethod, ExpectedException(typeof (ExpectationNotMetException))]
        public void ShouldRaiseExceptionWhenDoesntStartWith()
        {
            AString.Should().Start().With("14");
        }

        [TestMethod]
        public void ShouldNotStartWith()
        {
            AString.Should().Not().Start().With("14");
        }

        [TestMethod, ExpectedException(typeof (ExpectationNotMetException))]
        public void ShouldRaiseExceptionWhenNotEqualOrGreaterThanInLength()
        {
            "12".Should().Start().With("123");
        }

        [TestMethod, ExpectedException(typeof (ExpectationNotMetException))]
        public void ShouldRaiseExceptionIfStartWithUnexpected()
        {
            AString.Should().Not().Start().With("1");
        }

        [TestMethod]
        public void ShouldStartWithArray()
        {
            _arrayA.Should().Start().With(_arrayB);
        }

        [TestMethod]
        public void ShouldNotStartWithArray()
        {
            _arrayA.Should().Not().Start().With(new[] { 5, 6, 7, 8 });
        }
    }
}