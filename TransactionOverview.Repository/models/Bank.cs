using System.Collections.Generic;

namespace TransactionOverview.Repository.models
{
    public class Bank : EntityId
    {
        public string Name { get; set; }
        public string ImageSource { get; set; }
        public virtual List<Account> Accounts { get; set; }
    }
}