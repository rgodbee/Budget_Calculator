using BudgetCalculator.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BudgetCalculator.Entites.Tests
{
    [TestClass]
    public class ExpenseTest
    {
        [TestMethod]
        public void ExpenseExistsTest()
        {
            // setup
            //act
            var expense = new Expense();
            //assert
            Assert.IsNotNull(expense);
        }

        [TestMethod]
        public void ExpenseInheritsTransactionTest()
        {
            // setup
            var expense = new Expense();
            //act
            //assert
            Assert.IsNotNull(expense);
            Assert.IsInstanceOfType(expense, typeof(Transaction));
        }

        [TestMethod]
        public void ExpenseHasTypeTest()
        {
            // setup
            //act
            var expense = new Expense();
            //assert
            Assert.IsNotNull(expense);
            Assert.IsInstanceOfType(expense.Type, typeof(ExpenseType));
            Assert.IsNotNull(expense.Type);
            Assert.AreEqual(ExpenseType.Default, expense.Type);
        }
    }
}
