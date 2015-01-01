using System.Security.Policy;

namespace BudgetCalculator.Entities
{
    public enum ExpenseType
    {
        Default, Home, Auto, Utility, Food, Personal, Activities 
    }

    public class Expense:Transaction
    {
        private ExpenseType _type;

        public ExpenseType Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public Expense()
        {
            _type = ExpenseType.Default;
        }
    }
}