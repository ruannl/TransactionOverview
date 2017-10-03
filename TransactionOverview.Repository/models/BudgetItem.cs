
namespace TransactionOverview.Repository.models
{
    public class BudgetItem : EntityId
    {
        public BudgetItemCategory BudgetItemCategory { get; set; }
        public string BudgetItemName { get; set; }
        public string BudgetItemAmount { get; set; }
    }
}