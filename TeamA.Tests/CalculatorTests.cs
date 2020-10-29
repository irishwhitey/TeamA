using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace TeamA.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void ItShouldNeverBlowUp()
        {
            decimal defaultResult = new Calculator().GetResult("bv");
            Assert.That(-99, Is.EqualTo(defaultResult));
        }

        [Test]
        public void ItShouldHandlePower()
        {
            decimal result = new Calculator().GetResult("2 ^ 3");
            Assert.That(8, Is.EqualTo(result));
        }
        [Test]
        public void ItShouldHandleBasicAddition()
        {
            decimal result = new Calculator().GetResult("2 + 3");
            Assert.That(5, Is.EqualTo(result));
        }

        [Test]
        public void ItShouldHandleBasicSubtraction()
        {
            decimal result = new Calculator().GetResult("5 - 2");
            Assert.That(3, Is.EqualTo(result));
        }

        [Test]
        public void ItShouldHandleBasicMultiply()
        {
            decimal result = new Calculator().GetResult("5 * 2");
            Assert.That(10, Is.EqualTo(result));
        }

    }
}
