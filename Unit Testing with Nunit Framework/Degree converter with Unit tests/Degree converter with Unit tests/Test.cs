using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Degree_converter_with_Unit_tests
{
    [TestFixture]
    class Test
    {
        [Test]
        [TestCase (32,0)]
        public void Test_ToFarenheit(double expected, double C)
        {
            Assert.AreEqual(expected, Converter.ToFarenheit(C));
        }
        [Test]
        [TestCase (0,1)]
        public void Test_ToCelcius(double expected, double F)
        {
            var converter = new Converter();
            Assert.AreEqual(expected, converter.ToCelcius(F));
        }
    }
}
