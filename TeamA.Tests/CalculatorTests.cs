﻿using System;
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
        public void ItShouldAddNumbers()
        {
            var expected = 9;
            Assert.That(new Calculator().GetResult("5 + 4"), Is.EqualTo((expected)));
        }
    }
}
