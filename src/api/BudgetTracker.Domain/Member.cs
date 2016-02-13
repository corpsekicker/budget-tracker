using System.Collections.Generic;

namespace BudgetTracker.Domain
{
    public class Member
    {
        public string Name { get; set; }
        List<Transaction> Transactions { get; set; } = new List<Transaction>();
        public double MonthlyContribution { get; set; } 
    }
}