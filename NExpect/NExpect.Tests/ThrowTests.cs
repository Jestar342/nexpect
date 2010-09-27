using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NExpect.Exceptions;

namespace NExpect.Tests
{
    [TestClass]
    public class ThrowTests
    {
        [TestMethod]
        public void ShouldThrowException()
        {
            ((Action) (() => { throw new Exception(); })).Should().Throw<Exception>();
        }

        [TestMethod, ExpectedException(typeof (ExpectationNotMetException))]
        public void ShouldRaiseException()
        {
            ((Action)(() => { })).Should().Throw<Exception>();
        }

        [TestMethod]
        public void ShouldNotThrow()
        {
            ((Action)(() => { })).Should().Not().Throw<Exception>();
        }

        [TestMethod, ExpectedException(typeof (ExpectationNotMetException))]
        public void ShouldRaiseExceptionIfThrown()
        {
            ((Action)(() => { throw new Exception(); })).Should().Not().Throw<Exception>();
        }

        [TestMethod, ExpectedException(typeof (ExpectationNotMetException))]
        public void ShouldNotCatchUnspecifiedExceptionType()
        {
            ((Action)(() => { throw new ArgumentException(); })).Should().Throw<NotImplementedException>();
        }

        [TestMethod, ExpectedException(typeof(ExpectationNotMetException))]
        public void ShouldRaiseExceptionIfTargetNotAction()
        {
            1.Should().Throw<NotImplementedException>();
        }
    }
}