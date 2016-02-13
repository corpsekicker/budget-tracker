namespace BudgetTracker.StatementImporter
{
    /// <summary>
    /// Describes properties of the transaction item as positions delimited by a seperator character in a CSV file.
    /// </summary>
    public class PDFStatementSchema : IStatementSchema
    {
        public int DatePosition { get; set; }
        public int DescriptionPosition { get; set; }
        public int AmountPosition { get; set; }
    }
}