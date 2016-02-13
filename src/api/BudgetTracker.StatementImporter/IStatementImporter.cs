using System.Collections.Generic;
using BudgetTracker.Domain;

namespace BudgetTracker.StatementImporter
{
    internal interface IStatementImporter<TStatementSchema> where TStatementSchema : IStatementSchema
    {
        List<Transaction> ImportStatementTransactions(string filePath);
    }

    public abstract class StatementImporter<TStatementSchema> : IStatementImporter<TStatementSchema> where TStatementSchema : IStatementSchema
    {
        protected StatementImporter(TStatementSchema schema)
        {
            Schema = schema;
        }

        protected TStatementSchema Schema { get; set; }
        public abstract List<Transaction> ImportStatementTransactions(string filePath);
    }
}
