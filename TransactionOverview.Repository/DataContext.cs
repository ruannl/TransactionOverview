using System.Linq;
using TransactionOverview.Repository.models;

namespace TransactionOverview.Repository
{
    public class DataContext
    {
        public IQueryable<Bank> GetBanks()
        {
            using (var context = new TransactionOverviewDataContext())
            {
               return context.Bank.AsQueryable();
            }
        }
    }
}