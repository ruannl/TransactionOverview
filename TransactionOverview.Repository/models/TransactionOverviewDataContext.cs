using Microsoft.EntityFrameworkCore;

namespace TransactionOverview.Repository.models
{
    public class TransactionOverviewDataContext : DbContext
    {
        public DbSet<Bank> Bank { get; set; }
        public DbSet<Account> Account { get; set; }
        public DbSet<CardHolder> CardHolder { get; set; }
        public DbSet<BankCard> BankCard { get; set; }
        public DbSet<BudgetItem> BudgetItem { get; set; }
        public DbSet<BudgetItemCategory> BudgetItemCategory { get; set; }
        public DbSet<Retailer> Retailer { get; set; }
        public DbSet<RetailerIdentifier> RetailerIdentifier { get; set; }
        public DbSet<Statement> Statement { get; set; }
        public DbSet<Transaction> Transaction { get; set; }
        public DbSet<TransactionType> TransactionType { get; set; }
        public DbSet<TransactionTypeIdentifier> TransactionTypeIdentifier { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=dbTransactionOverview.db");
        }
    }
}