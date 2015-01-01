using System;
using BudgetCalculator.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BudgetCalculator.Entites.Tests
{
    [TestClass]
    public class IncomeTest
    {
        [TestMethod]
        public void IncomeExistsTest()
        {
            // setup
            // act
            var income = new Income();
            // assert
            Assert.IsNotNull(income);
            Assert.IsInstanceOfType(income, typeof(Transaction));
        }

        [TestMethod]
        public void IncomeHasTypeTest()
        {
            // setup
            var income = new Income();
            // act
            
            // assert
            Assert.IsNotNull(income);
            Assert.IsInstanceOfType(income.Type, typeof(IncomeType));
            Assert.IsNotNull(income.Type);
            Assert.AreEqual(IncomeType.Default, income.Type);
        }



    }
}
