using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NExpect.Tests
{
    [TestClass]
    public class EqualityTests
    {
        [TestMethod]
        public void ShouldBeEqual()
        {
            1.Should().Be().Equal().To(1);
        }

        [TestMethod, ExpectedException(typeof(ExpectationNotMetException))]
        public void ShouldEqualDifferentObjectShouldRaiseException()
        {
            1.Should().Be().Equal().To(2);
        }

        [TestMethod]
        public void ShouldNotBeEqual()
        {
            1.Should().Not().Be().Equal().To(2);
        }

        [TestMethod, ExpectedException(typeof(ExpectationNotMetException))]
        public void ShouldNotEqualSameObjectShouldRaiseException()
        {
            1.Should().Not().Be().Equal().To(1);
        }
    }
}