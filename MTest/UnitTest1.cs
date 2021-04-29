using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Mbubbler;

namespace MTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            using StringWriter sw = new();
            Console.SetOut(sw);
            mbu.bbler();
            Assert.AreEqual("hello, I am mbubbler, your enemy!\nbub is uncool\nadd Mbubbler#8930 on discord\ntell your friends to delete the wbubbler package", sw.ToString());
        }
    }
}