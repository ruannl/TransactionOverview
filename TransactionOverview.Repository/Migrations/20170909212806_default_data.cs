using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore.Migrations;
using TransactionOverview.Repository.models;

namespace TransactionOverview.Repository.Migrations
{
    public partial class default_data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            using (var context = new TransactionOverviewDataContext())
            {
                context.Bank.AddRange(new List<Bank>
            {
                new Bank {Name = "FNB", ImageSource = "Content/images/fnb.png"},
                new Bank {Name = "Standard Bank", ImageSource = "Content/images/standardbank.png"},
                new Bank {Name = "ABSA", ImageSource = "Content/images/absa.png"},
                new Bank {Name = "Investec", ImageSource = "Content/images/investec.png"},
                new Bank {Name = "Capitec", ImageSource = "Content/images/capitec.png"},
                new Bank {Name = "Nedbank", ImageSource = "Content/images/nedbank.png"},
            });
                context.SaveChanges();

                context.Account.AddRange(new List<Account>
                {
                    new Account
                {
                    Name = "R Linde Cheque",
                    AccountNumber = "62361804878",
                    Bank = context.Bank.First(x => x.Name == "FNB")
                },
                    new Account
                {
                    Name = "R Linde Credit",
                    AccountNumber = "448008******6000",
                    Bank = context.Bank.First(x => x.Name == "FNB")
                }
                });
                context.SaveChanges();

                context.CardHolder.AddRange(new List<CardHolder>
                {
                    new CardHolder {FirstName = "Ruann", LastName = "Linde"},
                    new CardHolder {FirstName = "Desire", LastName = "Linde"}
                });
                context.SaveChanges();

                context.BankCard.AddRange(new List<BankCard>
                {
                    new BankCard
                    {
                        Account = context.Account.First(x => x.AccountNumber == "62361804878"),
                        CardHolder = context.CardHolder.First(x => x.FirstName == "Ruann"),
                        CardNumber = "4009741000805814"
                    },
                    new BankCard
                    {
                        Account = context.Account.First(x => x.AccountNumber == "62361804878"),
                        CardHolder = context.CardHolder.First(x => x.FirstName == "Desire"),
                        CardNumber = "4790121006644611"
                    }
                });
                context.SaveChanges();

                context.BudgetItemCategory.AddRange(new List<BudgetItemCategory>
                {
                    new BudgetItemCategory { Name = "Banking"},
                    new BudgetItemCategory { Name = "Charities"},
                    new BudgetItemCategory { Name = "Education"},
                    new BudgetItemCategory { Name = "Entertainment"},
                    new BudgetItemCategory { Name = "Financial Services"},
                    new BudgetItemCategory { Name = "Family And Friends"},
                    new BudgetItemCategory { Name = "General"},
                    new BudgetItemCategory { Name = "Health And Beauty"},
                    new BudgetItemCategory { Name = "Holiday Expenses"},
                    new BudgetItemCategory { Name = "Household Maintenance"},
                    new BudgetItemCategory { Name = "Internet Service Providers"},
                    new BudgetItemCategory { Name = "Investments"},
                    new BudgetItemCategory { Name = "Legal Services"},
                    new BudgetItemCategory { Name = "Medical"},
                    new BudgetItemCategory { Name = "Municipalities"},
                    new BudgetItemCategory { Name = "OffShore"},
                    new BudgetItemCategory { Name = "Personal Services"},
                    new BudgetItemCategory { Name = "Rental Agencies"},
                    new BudgetItemCategory { Name = "Rent / Levies"},
                    new BudgetItemCategory { Name = "Retailers"},
                    new BudgetItemCategory { Name = "Salaries"},
                    new BudgetItemCategory { Name = "Scheduled Pre-paid"},
                    new BudgetItemCategory { Name = "Security Services"},
                    new BudgetItemCategory { Name = "Telecommunications"},
                    new BudgetItemCategory { Name = "Traffic Departments"},
                    new BudgetItemCategory { Name = "Transport"},
                    new BudgetItemCategory { Name = "Travel"},
                    new BudgetItemCategory { Name = "Unemployment Insurance"},
                    new BudgetItemCategory { Name = "Staff Costs"},
                    new BudgetItemCategory { Name = "Tax"},
                    new BudgetItemCategory { Name = "Traffic Departments"},
                    new BudgetItemCategory { Name = "Transport"},
                    new BudgetItemCategory { Name = "Utilities"}
                });
                context.SaveChanges();

                context.TransactionType.AddRange(new List<TransactionType>
                {
                    new TransactionType{ TransactionTypeName = "Bank Card Purchase"},
                    new TransactionType{ TransactionTypeName = "Bank Charges"},
                    new TransactionType{ TransactionTypeName = "Bank Transfer"},
                    new TransactionType{ TransactionTypeName = "Budget Item"},
                    new TransactionType{ TransactionTypeName = "Cash Withdrawal"},
                    new TransactionType{ TransactionTypeName = "Credits"},
                    new TransactionType{ TransactionTypeName = "Salaries"},
                    new TransactionType{ TransactionTypeName = "Debt Repayment"},
                    new TransactionType{ TransactionTypeName = "Fuel"},
                    new TransactionType{ TransactionTypeName = "Failed Transaction"},
                    new TransactionType{ TransactionTypeName = "Failed Transaction Reversal"},
                    new TransactionType{ TransactionTypeName = "Medical Payments"}
                });
                context.SaveChanges();

                context.TransactionTypeIdentifier.AddRange(new List<TransactionTypeIdentifier>
                {
                    new TransactionTypeIdentifier {Identifier = "purch", TransactionType = context.TransactionType.First(x => x.TransactionTypeName == "Bank Card Purchase")},
                    new TransactionTypeIdentifier {Identifier = "puch",TransactionType = context.TransactionType.First(x => x.TransactionTypeName == "Bank Card Purchase")},
                    new TransactionTypeIdentifier {Identifier = "CHEQUE CARD PURCHASE",TransactionType = context.TransactionType.First(x => x.TransactionTypeName == "Bank Card Purchase")},
                    new TransactionTypeIdentifier {Identifier = "DEBIT CARD PURCHASE",TransactionType = context.TransactionType.First(x => x.TransactionTypeName == "Bank Card Purchase")},

                    new TransactionTypeIdentifier {Identifier = "SMS SENDING",TransactionType = context.TransactionType.First(x => x.TransactionTypeName == "Bank Charges")},
                    new TransactionTypeIdentifier {Identifier = "EMAIL SENDING",TransactionType = context.TransactionType.First(x => x.TransactionTypeName == "Bank Charges")},
                    new TransactionTypeIdentifier {Identifier = "#VALUE",TransactionType = context.TransactionType.First(x => x.TransactionTypeName == "Bank Charges")},
                    new TransactionTypeIdentifier {Identifier = "#NON FNB",TransactionType = context.TransactionType.First(x => x.TransactionTypeName == "Bank Charges")},
                    new TransactionTypeIdentifier {Identifier = "#MONTHLY",TransactionType = context.TransactionType.First(x => x.TransactionTypeName == "Bank Charges")},
                    new TransactionTypeIdentifier {Identifier = "FEE - DEBIT ORDER",TransactionType = context.TransactionType.First(x => x.TransactionTypeName == "Bank Charges")},
                    new TransactionTypeIdentifier {Identifier = "FEE - OTHER BANK ATM",TransactionType = context.TransactionType.First(x => x.TransactionTypeName == "Bank Charges")},
                    new TransactionTypeIdentifier {Identifier = "CREDIT LIFE PROTECTION",TransactionType = context.TransactionType.First(x => x.TransactionTypeName == "Bank Charges")},
                    new TransactionTypeIdentifier {Identifier = "MEMBERSHIP FEE",TransactionType = context.TransactionType.First(x => x.TransactionTypeName == "Bank Charges")},
                    new TransactionTypeIdentifier {Identifier = "FEE: PAYMENT CONFIRM",TransactionType = context.TransactionType.First(x => x.TransactionTypeName == "Bank Charges")},
                    new TransactionTypeIdentifier {Identifier = "FEE - OTHER BANK ATM",TransactionType = context.TransactionType.First(x => x.TransactionTypeName == "Bank Charges")},
                    new TransactionTypeIdentifier {Identifier = "MONTHLY MANAGEMENT FEE",TransactionType = context.TransactionType.First(x => x.TransactionTypeName == "Bank Charges")},


                    new TransactionTypeIdentifier {Identifier = "IB TRANSFER TO",TransactionType = context.TransactionType.First(x => x.TransactionTypeName == "Bank Transfer")},

                    new TransactionTypeIdentifier {Identifier = "FNB H LOAN",TransactionType = context.TransactionType.First(x => x.TransactionTypeName == "Budget Item")},

                });
                context.SaveChanges();
            }
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
