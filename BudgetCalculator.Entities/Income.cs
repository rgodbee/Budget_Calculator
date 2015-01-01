namespace BudgetCalculator.Entities
{
    public enum IncomeType
    {
        Default, Salary, Tip, Gift, Passive
    }
    public class Income:Transaction
    {
        private IncomeType _type;

        public IncomeType Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public Income()
        {
            _type = IncomeType.Default;
        }
    }
}