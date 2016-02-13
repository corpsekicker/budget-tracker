using System.Collections.Generic;
using BudgetTracker.Domain;

namespace BudgetTracker.StatementImporter
{
    public class PDFStatementImporter : IStatementImporter
    {
        public List<Transaction> ImportStatementTransactions(string filePath)
        {
            throw new System.NotImplementedException();
        }
    }
}