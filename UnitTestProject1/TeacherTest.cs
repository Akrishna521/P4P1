using NUnit.Framework;
using Project1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace UnitTestProject1
{
    [TestFixture]
    internal class TeacherTest
    {
        [Test]
        public void TestTeacherId()
        {
            var teacher = new Teacher();
            teacher.TeacherId = 101;
            Assert.AreEqual(101, teacher.TeacherId);
        }
        [Test]
        public void TestTeacherName()
        {
            var teacher = new Teacher();
            teacher.TeacherName = "Mrs.Sheela";
            Assert.AreEqual("Mrs.Sheela", teacher.TeacherName);
        }
    }
}
