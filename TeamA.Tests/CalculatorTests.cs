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

    }
}
