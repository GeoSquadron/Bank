﻿using System;
using BankAccountNS;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankTest
{
    [TestClass]
    public class BankAccountTests
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        // unit test code
        [TestMethod]
        public void Debit_WithValidAmount_UpdateBalance() {
            // arrange
            double beginningBalance = 11.99;
            double debitAmount = 4.55;
            double expected = 7.44;
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);

            // act
            account.Debit(debitAmount);

            // assert
            double actual = account.Balance;
            Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");
        }
    }
}