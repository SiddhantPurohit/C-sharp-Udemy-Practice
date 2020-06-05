using NUnit.Framework;
using System;

namespace FizzBuzz_with_test
{
    [TestFixture]
    public class Tests
    {
        [Test]
        [TestCase("Fizz", 3)]
        [TestCase("Fizz", 9)]
        [TestCase("Buzz", 5)]
        [TestCase("Buzz", 20)]
        [TestCase("FizzBuzz", 30)]
        [TestCase("FizzBuzz", 90)]
        [TestCase("", 2)]
        public void TestFizzBuzz(string Expected, int i)
        {
            Assert.AreEqual(Expected, FizzBuzz.Ask(i));
        }
        [Test]
        public void Checktheconstant()
        {
            Assert.AreEqual (20, FizzBuzz.Test);
        } 
    }
}
