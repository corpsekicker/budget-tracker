namespace BudgetTracker.StatementImporter
{
    /// <summary>
    /// Describes properties of the transaction item as positions delimited by a seperator character in a CSV file.
    /// </summary>
    public class CSVStatementSchema : IStatementSchema
    {
        public char Delimiter { get; set; }
        public int DatePosition { get; set; }
        public int DescriptionPosition { get; set; }
        public int AmountPosition { get; set; }
        public int FirstLineIndex { get; set; }
    }
}