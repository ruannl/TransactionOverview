using System.Collections.Generic;

namespace TransactionOverview.Repository.models
{
    public class TransactionType : EntityId
    {
        public virtual List<Transaction> Transactions { get; set; }
        public virtual List<TransactionTypeIdentifier> TransactionTypeIdentifiers { get; set; }
        public string TransactionTypeName { get; set; }
    }
}