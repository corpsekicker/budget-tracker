using System;

namespace BudgetTracker.Domain
{
    public class Transaction
    {
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public double Amount { get; set; }
    }
}