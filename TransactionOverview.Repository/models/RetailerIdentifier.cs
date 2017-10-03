
namespace TransactionOverview.Repository.models { 
    public class RetailerIdentifier : EntityId
    {
        public Retailer Retailer { get; set; }
        public string Identifier { get; set; }
    }
}
