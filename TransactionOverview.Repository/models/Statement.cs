using System.Collections.Generic;

namespace TransactionOverview.Repository.models
{
    public class Statement : EntityId
    {
        public Statement()
        {
            Transactions = new List<Transaction>();
        }

        public Statement(string accountHolder,string accountNumber, decimal accountBalance,decimal availableBalance)
        {
            AccountHolder = accountHolder;
            AccountNumber = accountNumber;
            AccountBalance = accountBalance;
            AvailableBalance = availableBalance;
            Transactions = new List<Transaction>();
        }

        public Bank Bank { get; set; }
        public string AccountHolder { get; set; } 
        public string AccountNumber { get; set; } 
        public decimal AccountBalance { get; set; } 
        public decimal AvailableBalance { get; set; } 
        public List<Transaction> Transactions { get; set; }
    }
}