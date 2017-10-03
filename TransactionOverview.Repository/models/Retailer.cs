using System.Collections.Generic;

namespace TransactionOverview.Repository.models
{
    public class Retailer : EntityId
    {
        public virtual List<Transaction> Transactions { get; set; }
        public List<RetailerIdentifier> RetailerIdentifiers { get; set; }
        public string Name { get; set; }
    }
}
