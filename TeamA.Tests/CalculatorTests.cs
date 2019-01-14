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
            var expected = 7;
            Assert.That(new Calculator().GetResult("3 + 4"), Is.EqualTo(expected));
        }

        [Test]
        public void adding3numberstogther()
        {
            var expected = 9;
            Assert.That(new Calculator().GetResult("3 + 4 + 2"), Is.EqualTo(expected));
        }

        [Test]
        public void ItShouldNotBreak()
        {
            new Calculator().GetResult("fred + ");
        }

        
        //public void ItShouldTheCorrectAnswert(string problem, int expectedValue)
        //{
        //    Assert.That(new Calculator().GetResult(problem), Is.EqualTo(expectedValue));
        //}
    }
}
