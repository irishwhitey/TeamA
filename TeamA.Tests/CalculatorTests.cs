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
            var expected1 = 9;
            var expected2 = 12;

            Assert.That(new Calculator().GetResult("3 + 4 + 2"), Is.EqualTo(expected1));
            Assert.That(new Calculator().GetResult("9 + 2 + 1"), Is.EqualTo(expected2));
        }

        [Test]
        public void addingnegativeandpositivenumberstogether()
        {
            Assert.That(new Calculator().GetResult("-3 + 4"), Is.EqualTo(1));
        }

        [Test]
        public void candividenumbers()
        {
            Assert.That(new Calculator().GetResult("8 / 4"), Is.EqualTo(2));
        }

        [Test]
        public void ItShouldNotBreak()
        {
            new Calculator().GetResult("fred + ");
            new Calculator().GetResult("foo");
            new Calculator().GetResult("10 - 4 + 2");
            new Calculator().GetResult("10 + -4");
            new Calculator().GetResult("3 * 1 * -4");
        }

        
        //public void ItShouldTheCorrectAnswert(string problem, int expectedValue)
        //{
        //    Assert.That(new Calculator().GetResult(problem), Is.EqualTo(expectedValue));
        //}
    }
}
