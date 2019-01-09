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

        [Test]
        public void ItShouldNotBreak()
        {
            new Calculator().GetResult("fred + ");
        }


        [TestCase("0", 0)]
        [TestCase("3 + 4",7)]
        [TestCase("5 + 2 + 1",8)]
        [TestCase("3 - 1",2)]		
        [TestCase("-3 + 4",1)]
        //[TestCase("3 + 4 - 1",6)]
        [TestCase("100 + 2",102)]
        [TestCase("3 - 3",0)]		
        [TestCase("5 * 2",10)]
        [TestCase("6 / 2",3)]
        [TestCase("8 - 2",6)]				
        //[TestCase("5 + 2 - 3",4)]
        //[TestCase("(4 + 2) * 2",12)]
        //[TestCase("2 ^ 3",8)]
        //[TestCase("-3 - 3",-6)]
        [TestCase("10 - 7",3)]
        //[TestCase("(3 + 2) * (4 + 2)",30)]
        public void ItShouldTheCorrectAnswert(string problem, int expectedValue)
        {
            Assert.That(new Calculator().GetResult(problem), Is.EqualTo(expectedValue));
        }
    }
}
