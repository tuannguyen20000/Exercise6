using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using bank;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTestAccount
    {
        [TestMethod]
        public void TestMethodAccount()
        {
            account acc = new account(20000);
            Assert.IsNotNull(acc);
            Assert.IsInstanceOfType(acc, typeof(account));
            Assert.AreEqual(20000, acc.Balance());
        }

    }
}
