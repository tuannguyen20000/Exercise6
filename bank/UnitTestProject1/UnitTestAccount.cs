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
        [TestMethod]
        public void TestMethodDeposit()
        {
            account acc = new account(200000);
            acc.Deposit(200000);
            Assert.IsNotNull(acc);
            Assert.IsInstanceOfType(acc, typeof(account));
            Assert.AreEqual(400000, acc.Balance());
        }
        [TestMethod]
        public void TestMethodWithDraw()
        {
            account acc = new account(200000);
            acc.WithDraw(100000);
            Assert.IsNotNull(acc);
            Assert.IsInstanceOfType(acc, typeof(account));
            Assert.AreEqual(100000, acc.Balance());
        }
    }
}
