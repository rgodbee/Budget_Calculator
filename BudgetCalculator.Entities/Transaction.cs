using System;

namespace BudgetCalculator.Entities
{
    public abstract class Transaction
    {
        private decimal _amount;
        private String _name;
        private DateTime _date;

        public decimal Amount
        {
            get { return _amount; } 
            set { _amount = value; }
        }

        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public DateTime Date
        {
            get { return _date; }
        }

        public Transaction()
        {
            _name = "";
            _date = DateTime.MinValue;
        }
    }
}
