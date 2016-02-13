using System.Collections.Generic;

namespace BudgetTracker.Domain
{
    public class Household
    {
        public string Name { get; set; }
        public double  MonthlyBudget { get; set; }
        List<Member> Members { get; set; } = new List<Member>();
    }
}
