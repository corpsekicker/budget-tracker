using System.Collections.Generic;
using BudgetTracker.Domain;
using BudgetTracker.StatementImporter;
using NUnit.Framework;

namespace BudgetTracker.Tests.StatementImporterTests
{
    [TestFixture]
    public class CSVImporterTests
    {
        [Test]
        public void CanImportTransactionItems()
        {
            // Arrange:
            var csvFilePath = @"C:\Users\kismail\Desktop\January Budget\62098154728.csv";
            var fnbCsvSchema  = new CSVStatementSchema()
            {
                Delimiter = ',',
                DatePosition = 0,
                AmountPosition = 1,
                DescriptionPosition = 3,
                FirstLineIndex = 7
            };

            // Act:
            var csvImporter = new CsvStatementImporter(fnbCsvSchema);
            var importedTransactions = csvImporter.ImportStatementTransactions(csvFilePath);

            // Assert:
            Assert.That(importedTransactions.Count > 0);
        }
    }
}
