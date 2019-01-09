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
        public void ItShouldReturnSomething()
        {
            var expected = 0;
            Assert.That(new Calculator().GetResult(""), Is.EqualTo(expected));
        }

        [TestCase("",0)]
        [TestCase("3 + 4", 7)]
        public void ItShouldTheCorrectAnswert(string problem, int expectedValue)
        {
            Assert.That(new Calculator().GetResult(problem), Is.EqualTo(expectedValue));
        }
    }
}
