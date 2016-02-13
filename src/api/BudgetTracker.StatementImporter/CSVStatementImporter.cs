using System;
using System.Collections.Generic;
using System.IO;
using BudgetTracker.Domain;

namespace BudgetTracker.StatementImporter
{
    public class CsvStatementImporter : StatementImporter<CSVStatementSchema>
    {
        public CsvStatementImporter(CSVStatementSchema schema) : base(schema)
        {
        }

        public override List<Transaction> ImportStatementTransactions(string filePath)
        {
            var lines = new List<string>();
            using (StreamReader sr = new StreamReader(filePath))
            {
                var lineIndex = 0;
                while (sr.Peek() >= 0)
                {
                    var line = sr.ReadLine();
                    if (lineIndex >= Schema.FirstLineIndex)
                    {
                        lines.Add(line);
                    }
                    lineIndex++;
                }
            }

            var transactions = new List<Transaction>();
            foreach (var line in lines)
            {
                var lineProperties = line.Split(Schema.Delimiter);
                var transaction = new Transaction
                {
                    Date = DateTime.Parse(lineProperties[Schema.DatePosition]),
                    Amount = double.Parse(lineProperties[Schema.AmountPosition]),
                    Description = lineProperties[Schema.DescriptionPosition]
                };
                transactions.Add(transaction);
            }

            return transactions;
        }
    }
}