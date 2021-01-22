using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Trello;

namespace UnitTestTrello
{
    [TestClass]
    public class UnitTest1 
    {
        [TestMethod]
        public void TestMethod1()
        {
            Login lgn = new Login();
            int result = lgn.Giris("asrin");
            Assert.AreEqual(1, result);
        }
    }
}
