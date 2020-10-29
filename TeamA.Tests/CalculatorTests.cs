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
        public void SimpleSquareTest()
        {
            decimal result = new Calculator().GetResult("3 ^ 2");

            Assert.That(9, Is.EqualTo(result));
        }
    }
}
