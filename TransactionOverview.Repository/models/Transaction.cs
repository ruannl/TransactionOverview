using System;

namespace TransactionOverview.Repository.models
{
    public class Transaction : EntityId
    {
        public Statement Statement { get; set; }
        public TransactionType TransactionType  { get; set; }
        public BankCard BankCard { get; set; }
        public Retailer Retailer { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public decimal Balance { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
    }
}