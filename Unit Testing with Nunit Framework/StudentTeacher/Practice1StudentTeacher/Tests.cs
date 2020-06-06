using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practice1StudentTeacher
{
    [TestFixture]
    class Tests
    {
        [Test]
        public void CheckGreet()
        {
            Assert.AreEqual("Hello", Person.Greet());
        }

        [Test]
        public void CheckStudent()
        {
            var testStudent = new Student();
            testStudent.setAge(20);
            Assert.AreEqual(20, testStudent.Age);
        }

        [Test]
        public void CheckTeacher()
        {
            var testteacher = new Teacher();
            testteacher.setAge(30);
            Assert.IsTrue(testteacher.Age == 30);
        }
    }
}