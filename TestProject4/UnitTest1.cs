using NUnit.Framework;
using System;


namespace TestProject3
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestForWriteLine()
        {
            Logger l1 = Logger.Initialize();
            l1.WriteLine("aaa");
            string actual = l1.Information;
            string expected = "aaa ";
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestForWriteLineTwo()
        {
            Logger l1 = Logger.Initialize();
            l1.Delete();
            l1.WriteLine("kpi");
            l1.WriteLine("love");
            string actual = l1.Information;
            string expected = "kpi love ";
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestForWriteLineNumber()
        {
            Logger l1 = Logger.Initialize();
            l1.Delete();
            l1.WriteNumber(100);
            string actual = l1.Information;
            string expected = "100 ";
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestForWriteLineNumberAndLine()
        {
            Logger l1 = Logger.Initialize();
            l1.Delete();
            l1.WriteNumber(2021);
            l1.WriteLine("year");
            string actual = l1.Information;
            string expected = "2021 year ";
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestForInstance()
        {
            Logger l1 = Logger.Initialize();
            Logger l2 = Logger.Initialize();
            Logger actual = l1;
            Logger expected = l2;
            Assert.AreEqual(expected, actual);
        }
    }
}