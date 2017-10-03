using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore.Migrations;
using TransactionOverview.Repository.models;

namespace TransactionOverview.Repository
{
    public partial class DefaultDataMigration : Migration
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

        //    AddTransactionIdentifiers("FNB H LOAN", "Budget Item");
        //    AddTransactionIdentifiers("BMWFINANCE", "Budget Item");
        //    AddTransactionIdentifiers("M-CHOICE", "Budget Item");
        //    AddTransactionIdentifiers("AFRIHOST", "Budget Item");
        //    AddTransactionIdentifiers("DISC PREM", "Budget Item");
        //    AddTransactionIdentifiers("OUTSURANCE", "Budget Item");
        //    AddTransactionIdentifiers("ATFIGHTFIT", "Budget Item");
        //    AddTransactionIdentifiers("VIRGIN ACT", "Budget Item");
        //    AddTransactionIdentifiers("PREPAID ELECTRICITY", "Budget Item");
        //    AddTransactionIdentifiers("JOHANNA", "Budget Item");
        //    AddTransactionIdentifiers("FANIE (GARDNER)", "Budget Item");
        //    AddTransactionIdentifiers("MOREGOLF", "Budget Item");
        //    AddTransactionIdentifiers("NATHAN", "Budget Item");
        //    AddTransactionIdentifiers("BRANDON", "Budget Item");
        //    AddTransactionIdentifiers("TELKOM", "Budget Item");
        //    AddTransactionIdentifiers("DISCLIFE", "Budget Item");
        //    AddTransactionIdentifiers("RATES & TAX", "Budget Item");
        //    AddTransactionIdentifiers("VODACOM", "Budget Item");
        //    AddTransactionIdentifiers("INSURANCE PREMIUM", "Budget Item");
        //    AddTransactionIdentifiers("ACCOUNT PAYMENT", "Budget Item");
        //    AddTransactionIdentifiers("SWIMMING", "Budget Item");
        //    AddTransactionIdentifiers("KLEENBIN", "Budget Item");
        //    AddTransactionIdentifiers("CYCOL LAWNS", "Budget Item");
        //    AddTransactionIdentifiers("IB PAYMENT TO", "Budget Item", "GARSFONTEIN LAER");
        //    AddTransactionIdentifiers("IB PAYMENT TO", "Budget Item", "GA WAIT");
        //    AddTransactionIdentifiers("IB PAYMENT TO", "Budget Item", "GA WAIT");
        //    AddTransactionIdentifiers("ACCOUNT PAYMENT", "Budget Item", "CARTRACK");


        //    AddTransactionIdentifiers("ATM CASH", "Cash Withdrawal");
        //    AddTransactionIdentifiers("CASH", "Cash Withdrawal");

        //    AddTransactionIdentifiers("DU PREEZ PHYSIO", "Medical Payments");
        //    AddTransactionIdentifiers("DR LH FORBES", "Medical Payments");

        //    AddTransactionIdentifiers("SALARY", "Salaries");
        //    AddTransactionIdentifiers("CREDIT TRANSFER", "Salaries", "Anys Rossouw");

        //    AddTransactionIdentifiers("SHORT TERM LOAN CREDI", "Credits");
        //    AddTransactionIdentifiers("CASH DEPOSIT", "Credits");
        //    AddTransactionIdentifiers("IB PAYMENT FROM", "Credits");
        //    AddTransactionIdentifiers("ELECTRONIC BANKING PAYMENT FR", "Credits");


        //    AddTransactionIdentifiers("TRANSACTION REVERSAL", "Credits");
        //    AddTransactionIdentifiers("MAGTAPE CREDIT", "Credits");
        //    AddTransactionIdentifiers("DR INTEREST REBATE", "Credits");
        //    AddTransactionIdentifiers("FNB APP TRANSFER FROM", "Credits");
        //    AddTransactionIdentifiers("FNB APP PAYMENT FROM", "Credits");

        //    AddTransactionIdentifiers("INT ON DEBIT BALANCE", "Debt Repayment");
        //    AddTransactionIdentifiers("FNB CARD", "Debt Repayment");
        //    AddTransactionIdentifiers("LOAN REPAYME", "Debt Repayment");
        //    AddTransactionIdentifiers("INTEREST ON OVERDRAFT", "Debt Repayment");
        //    AddTransactionIdentifiers("SHORT TERM LOAN REPAY", "Debt Repayment");
        //    AddTransactionIdentifiers("NAEDO DEBIT", "Debt Repayment");

        //    AddTransactionIdentifiers("PINNGUARD", "Failed Transaction");
        //    AddTransactionIdentifiers("#RETURNED ITEM CHARGED", "Failed Transaction");
        //    AddTransactionIdentifiers("FEE- POS DECLINED INSUFF FUNDS", "Failed Transaction");

        //    AddTransactionIdentifiers("fuel", "Fuel");

        //    AddTransactionIdentifiers("MAGTAPE", "Failed Transaction Reversal");
        //    AddTransactionIdentifiers("FEE-UNPAID ITEM", "Failed Transaction Reversal");

        //    AddRetailer("Caltex");
        //    AddRetailer("Checkers");
        //    AddRetailer("Builders Warehouse");
        //    AddRetailer("Dis-Chem");
        //    AddRetailer("Engen");
        //    AddRetailer("MBT");
        //    AddRetailer("Pick & Pay");
        //    AddRetailer("Spar");
        //    AddRetailer("KFC");
        //    AddRetailer("Liquor Store");
        //    AddRetailer("Toll Gate");
        //    AddRetailer("Pharmacy");
        //    AddRetailer("Steers");
        //    AddRetailer("Wimpy");
        //    AddRetailer("JSE Coffee Shop");
        //    AddRetailer("Twisp");
        //    AddRetailer("Dog Parlour");
        //    AddRetailer("Boma Vleismark");
        //    AddRetailer("Chamberlains");
        //    AddRetailer("Clicks");
        //    AddRetailer("Mr Price Home");
        //    AddRetailer("Mr Price Sport");
        //    AddRetailer("Metro");
        //    AddRetailer("Sheet Street");
        //    AddRetailer("Plastic Land");
        //    AddRetailer("Animal Kingdom");
        //    AddRetailer("Mimmos");
        //    AddRetailer("Barcelos");
        //    AddRetailer("Gautrain");
        //    //AddRetailer("");
        //    //AddRetailer("");

        //    AddRetailerIdentifiers("Caltex", "Caltex");
        //    AddRetailerIdentifiers("Checkers", "Checkers");
        //    AddRetailerIdentifiers("Builders Warehouse", "Builders Warehouse");
        //    AddRetailerIdentifiers("DIS-CHEM", "Dis-Chem");
        //    AddRetailerIdentifiers("MENLYN QUICK STOP", "Engen");
        //    AddRetailerIdentifiers("MENLYN QUICKSTOP", "Engen");
        //    AddRetailerIdentifiers("MBT", "MBT");
        //    AddRetailerIdentifiers("PUCHC PNP", "Pick & Pay");
        //    AddRetailerIdentifiers("PURCH PNP", "Pick & Pay");
        //    AddRetailerIdentifiers("PNP HYPER ", "Pick & Pay");
        //    AddRetailerIdentifiers("MORELETA SUPERSPAR", "Spar");
        //    AddRetailerIdentifiers("KFC", "KFC");
        //    AddRetailerIdentifiers("CONSTANTIA LIQU", "Liquor Store");
        //    AddRetailerIdentifiers("LIQUOR", "Liquor Store");
        //    AddRetailerIdentifiers("M#DORNPOORT PLAZA", "Toll Gate");
        //    AddRetailerIdentifiers("TOLLGATE", "Toll Gate");
        //    AddRetailerIdentifiers("PHARMACY", "Pharmacy");
        //    AddRetailerIdentifiers("Steers", "Steers");
        //    AddRetailerIdentifiers("Wimpy", "Wimpy");
        //    AddRetailerIdentifiers("FEGO", "JSE Coffee Shop");
        //    AddRetailerIdentifiers("Twisp", "Twisp");
        //    AddRetailerIdentifiers("LE YORK", "Dog Parlour");
        //    AddRetailerIdentifiers("Boma Vleismark", "Boma Vleismark");
        //    AddRetailerIdentifiers("Chamberlain", "Chamberlains");
        //    AddRetailerIdentifiers("Clicks", "Clicks");
        //    AddRetailerIdentifiers("Mr Price Home", "Mr Price Home");
        //    AddRetailerIdentifiers("Mr Price Sport", "Mr Price Sport");
        //    AddRetailerIdentifiers("METRO HOME", "Metro");
        //    AddRetailerIdentifiers("Sheet Street", "Sheet Street");
        //    AddRetailerIdentifiers("Plastic Land", "Plastic Land");
        //    AddRetailerIdentifiers("Animal Kingdom", "Animal Kingdom");
        //    AddRetailerIdentifiers("MIMMOS", "Mimmos");
        //    AddRetailerIdentifiers("BARCELOS", "Barcelos");
        //    AddRetailerIdentifiers("Gautrain", "Gautrain");
    }
}