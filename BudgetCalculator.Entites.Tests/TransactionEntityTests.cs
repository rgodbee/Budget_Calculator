using System;
using BudgetCalculator.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BudgetCalculator.Entites.Tests
{
    [TestClass]
    public class TransactionEntityTests
    {
        [TestMethod]
        public void TransactionEntityExistsTest()
        {
            // setup
            
            // act
            var transaction = new Expense();
            
            // assert
            Assert.IsNotNull(transaction);
        }

        [TestMethod]
        public void TransactionEntityHasAmountFieldTest()
        {
            // setup
            var transaction = new Expense();
            // act
            
            // assert
            Assert.IsNotNull(transaction);
            Assert.IsNotNull(transaction.Amount);
            Assert.IsInstanceOfType(transaction.Amount, typeof(decimal));
            Assert.AreEqual(0.0m,transaction.Amount);
        }

        [TestMethod]
        public void TransactionEntityHasNameTest()
        {
            // setup
            var transaction = new Expense();
            // act
            
            // assert
            Assert.IsNotNull(transaction);
            Assert.IsNotNull(transaction.Name);
            Assert.IsInstanceOfType(transaction.Name, typeof(String));
            Assert.AreEqual("", transaction.Name);
        }

        [TestMethod]
        public void TransactionEntityHasDateTest()
        {
            // setup

            // act
            var transaction = new Expense();

            // assert
            Assert.IsNotNull(transaction);
            Assert.IsNotNull(transaction.Date);
            Assert.IsInstanceOfType(transaction.Date, typeof(DateTime));
            Assert.AreEqual(DateTime.MinValue, transaction.Date);
        }
    }
}
