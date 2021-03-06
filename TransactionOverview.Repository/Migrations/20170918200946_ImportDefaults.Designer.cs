﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using TransactionOverview.Repository.models;

namespace TransactionOverview.Repository.Migrations
{
    [DbContext(typeof(TransactionOverviewDataContext))]
    [Migration("20170918200946_ImportDefaults")]
    partial class ImportDefaults
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452");

            modelBuilder.Entity("TransactionOverview.Repository.models.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AccountNumber");

                    b.Property<int?>("BankId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("BankId");

                    b.ToTable("Account");
                });

            modelBuilder.Entity("TransactionOverview.Repository.models.Bank", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ImageSource");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Bank");
                });

            modelBuilder.Entity("TransactionOverview.Repository.models.BankCard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AccountId");

                    b.Property<int?>("CardHolderId");

                    b.Property<string>("CardNumber");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("CardHolderId");

                    b.ToTable("BankCard");
                });

            modelBuilder.Entity("TransactionOverview.Repository.models.BudgetItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BudgetItemAmount");

                    b.Property<int?>("BudgetItemCategoryId");

                    b.Property<string>("BudgetItemName");

                    b.HasKey("Id");

                    b.HasIndex("BudgetItemCategoryId");

                    b.ToTable("BudgetItem");
                });

            modelBuilder.Entity("TransactionOverview.Repository.models.BudgetItemCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("BudgetItemCategory");
                });

            modelBuilder.Entity("TransactionOverview.Repository.models.CardHolder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.HasKey("Id");

                    b.ToTable("CardHolder");
                });

            modelBuilder.Entity("TransactionOverview.Repository.models.Retailer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Retailer");
                });

            modelBuilder.Entity("TransactionOverview.Repository.models.RetailerIdentifier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Identifier");

                    b.Property<int?>("RetailerId");

                    b.HasKey("Id");

                    b.HasIndex("RetailerId");

                    b.ToTable("RetailerIdentifier");
                });

            modelBuilder.Entity("TransactionOverview.Repository.models.Statement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("AccountBalance");

                    b.Property<string>("AccountHolder");

                    b.Property<int?>("AccountId");

                    b.Property<string>("AccountNumber");

                    b.Property<decimal>("AvailableBalance");

                    b.Property<int?>("BankId");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("BankId");

                    b.ToTable("Statement");
                });

            modelBuilder.Entity("TransactionOverview.Repository.models.Transaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Amount");

                    b.Property<decimal>("Balance");

                    b.Property<int?>("BankCardId");

                    b.Property<DateTime>("Date");

                    b.Property<string>("Description");

                    b.Property<int?>("RetailerId");

                    b.Property<int?>("StatementId");

                    b.Property<int?>("TransactionTypeId");

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.HasIndex("BankCardId");

                    b.HasIndex("RetailerId");

                    b.HasIndex("StatementId");

                    b.HasIndex("TransactionTypeId");

                    b.ToTable("Transaction");
                });

            modelBuilder.Entity("TransactionOverview.Repository.models.TransactionType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("TransactionTypeName");

                    b.HasKey("Id");

                    b.ToTable("TransactionType");
                });

            modelBuilder.Entity("TransactionOverview.Repository.models.TransactionTypeIdentifier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Identifier");

                    b.Property<int?>("TransactionTypeId");

                    b.HasKey("Id");

                    b.HasIndex("TransactionTypeId");

                    b.ToTable("TransactionTypeIdentifier");
                });

            modelBuilder.Entity("TransactionOverview.Repository.models.Account", b =>
                {
                    b.HasOne("TransactionOverview.Repository.models.Bank", "Bank")
                        .WithMany("Accounts")
                        .HasForeignKey("BankId");
                });

            modelBuilder.Entity("TransactionOverview.Repository.models.BankCard", b =>
                {
                    b.HasOne("TransactionOverview.Repository.models.Account", "Account")
                        .WithMany("BankCards")
                        .HasForeignKey("AccountId");

                    b.HasOne("TransactionOverview.Repository.models.CardHolder", "CardHolder")
                        .WithMany()
                        .HasForeignKey("CardHolderId");
                });

            modelBuilder.Entity("TransactionOverview.Repository.models.BudgetItem", b =>
                {
                    b.HasOne("TransactionOverview.Repository.models.BudgetItemCategory", "BudgetItemCategory")
                        .WithMany("BudgetItems")
                        .HasForeignKey("BudgetItemCategoryId");
                });

            modelBuilder.Entity("TransactionOverview.Repository.models.RetailerIdentifier", b =>
                {
                    b.HasOne("TransactionOverview.Repository.models.Retailer", "Retailer")
                        .WithMany("RetailerIdentifiers")
                        .HasForeignKey("RetailerId");
                });

            modelBuilder.Entity("TransactionOverview.Repository.models.Statement", b =>
                {
                    b.HasOne("TransactionOverview.Repository.models.Account")
                        .WithMany("Statements")
                        .HasForeignKey("AccountId");

                    b.HasOne("TransactionOverview.Repository.models.Bank", "Bank")
                        .WithMany()
                        .HasForeignKey("BankId");
                });

            modelBuilder.Entity("TransactionOverview.Repository.models.Transaction", b =>
                {
                    b.HasOne("TransactionOverview.Repository.models.BankCard", "BankCard")
                        .WithMany()
                        .HasForeignKey("BankCardId");

                    b.HasOne("TransactionOverview.Repository.models.Retailer", "Retailer")
                        .WithMany("Transactions")
                        .HasForeignKey("RetailerId");

                    b.HasOne("TransactionOverview.Repository.models.Statement", "Statement")
                        .WithMany("Transactions")
                        .HasForeignKey("StatementId");

                    b.HasOne("TransactionOverview.Repository.models.TransactionType", "TransactionType")
                        .WithMany("Transactions")
                        .HasForeignKey("TransactionTypeId");
                });

            modelBuilder.Entity("TransactionOverview.Repository.models.TransactionTypeIdentifier", b =>
                {
                    b.HasOne("TransactionOverview.Repository.models.TransactionType", "TransactionType")
                        .WithMany("TransactionTypeIdentifiers")
                        .HasForeignKey("TransactionTypeId");
                });
#pragma warning restore 612, 618
        }
    }
}
