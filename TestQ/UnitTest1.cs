using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestQ
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            double beginningBalance = 11.99;
            double debitAmount = 4.55;
            double expected = 7.44;
            //BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);

            // act
           // account.Debit(debitAmount);

            // assert
            double actual = 56;
            Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");
        }
    }
}
