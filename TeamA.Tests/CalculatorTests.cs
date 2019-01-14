using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace TeamA.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
    //    [Test]
    //    public void ItShouldReturnSomething()
    //    {
    //        var expected = 0;
    //        Assert.That(new Calculator().GetResult(""), Is.EqualTo(expected));
    //    }

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
