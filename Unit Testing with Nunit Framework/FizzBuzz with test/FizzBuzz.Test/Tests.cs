using NUnit.Framework;
using System;
using FizzBuzz_with_test;

namespace FizzBuzz.Test
{
    [TestFixture]
    public class Tests
    {
        [Test]
        [TestCase("Fizz",3)]
        public void TestFizzBuzz (string Expected, int i)
        {
            Assert.AreEqual(Expected, FizzBuzz.Ask(i));
        }
    }
}
