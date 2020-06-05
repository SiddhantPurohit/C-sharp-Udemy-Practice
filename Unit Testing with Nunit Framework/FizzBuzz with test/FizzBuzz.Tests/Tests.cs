using NUnit.Framework;

namespace FizzBuzz.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        [TestCase("Fizz",3)]
        [TestCase("Buzz",5)]
        [TestCase("Fizz Buzz", 15)]
        public void TestFizzBuzz (string Expected, int i)
        {
            Assert.AreEqual(Expected, FizzBuzz.Ask(i));
        }
     
    }
}
