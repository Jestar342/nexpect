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
            AString.Should().StartWith("12");
        }

        [TestMethod, ExpectedException(typeof (ExpectationNotMetException))]
        public void ShouldRaiseExceptionWhenDoesntStartWith()
        {
            AString.Should().StartWith("14");
        }

        [TestMethod]
        public void ShouldNotStartWith()
        {
            AString.Should().Not().StartWith("14");
        }

        [TestMethod, ExpectedException(typeof (ExpectationNotMetException))]
        public void ShouldRaiseExceptionWhenNotEqualOrGreaterThanInLength()
        {
            "12".Should().StartWith("123");
        }

        [TestMethod, ExpectedException(typeof (ExpectationNotMetException))]
        public void ShouldRaiseExceptionIfStartWithUnexpected()
        {
            AString.Should().Not().StartWith("1");
        }

        [TestMethod]
        public void ShouldStartWithArray()
        {
            _arrayA.Should().StartWith(_arrayB);
        }

        [TestMethod]
        public void ShouldNotStartWithArray()
        {
            _arrayA.Should().Not().StartWith(new[] {5, 6, 7, 8});
        }
    }
}