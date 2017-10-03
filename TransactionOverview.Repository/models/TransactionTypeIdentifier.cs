namespace TransactionOverview.Repository.models
{
    public class TransactionTypeIdentifier : EntityId
    {
        public TransactionType TransactionType { get; set; }
        public string Identifier { get; set; }
    }
}