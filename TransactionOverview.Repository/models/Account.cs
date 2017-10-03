using System.Collections.Generic;

namespace TransactionOverview.Repository.models
{
    public class Account : EntityId
    {
        public string Name { get; set; }
        public string AccountNumber { get; set; }
        public Bank Bank { get; set; }
        public virtual List<Statement> Statements { get; set; }
        public virtual List<BankCard> BankCards { get; set; }
    }
}