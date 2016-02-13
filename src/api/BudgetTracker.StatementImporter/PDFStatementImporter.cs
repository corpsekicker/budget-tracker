using System.Collections.Generic;
using BudgetTracker.Domain;

namespace BudgetTracker.StatementImporter
{
    public class PdfStatementImporter : StatementImporter<PDFStatementSchema>
    {
        public override List<Transaction> ImportStatementTransactions(string filePath)
        {
            throw new System.NotImplementedException();
        }

        public PdfStatementImporter(PDFStatementSchema schema) : base(schema)
        {
        }
    }
}