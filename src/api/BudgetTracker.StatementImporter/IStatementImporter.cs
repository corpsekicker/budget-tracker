using System.Collections.Generic;
using BudgetTracker.Domain;

namespace BudgetTracker.StatementImporter
{
    public interface IStatementImporter
    {
        List<Transaction> ImportStatementTransactions(string filePath);
    }
}
