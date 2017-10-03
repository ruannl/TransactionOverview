using System.Collections.Generic;

namespace TransactionOverview.Repository.models
{
    public class BudgetItemCategory : EntityId
    {
        public virtual List<BudgetItem> BudgetItems { get; set; }
        public string Name { get; set; }
    }
}
