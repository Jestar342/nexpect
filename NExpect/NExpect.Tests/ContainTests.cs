using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NExpect.Exceptions;

namespace NExpect.Tests
{
    [TestClass]
    public class ContainTests
    {
        private readonly List<int> _list = new List<int> {1, 2, 3};

        [TestMethod]
        public void ShouldContain()
        {
            _list.Should().Contain(2);
        }

        [TestMethod, ExpectedException(typeof (ExpectationNotMetException))]
        public void ShouldRaiseExceptionWhenDoesntContain()
        {
            _list.Should().Contain(5);
        }

        [TestMethod]
        public void ShouldNotContain()
        {
            _list.Should().Not().Contain(5);
        }

        [TestMethod, ExpectedException(typeof (ExpectationNotMetException))]
        public void ShouldRaiseExceptionWhenDoesContainNotExcpectedItem()
        {
            _list.Should().Not().Contain(2);
        }

        [TestMethod, ExpectedException(typeof (ExpectationNotMetException))]
        public void ShouldRaiseExceptionIfTargetNotICollection()
        {
            1.Should().Contain("123");
        }
    }
}