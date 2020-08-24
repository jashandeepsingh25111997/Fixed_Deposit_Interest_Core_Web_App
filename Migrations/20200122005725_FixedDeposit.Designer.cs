﻿// <auto-generated />
using Fixed_Deposit_Interest_Core_Web_App.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Fixed_Deposit_Interest_Core_Web_App.Migrations
{
    [DbContext(typeof(Fixed_Deposit_Interest_Context))]
    [Migration("20200122005725_FixedDeposit")]
    partial class FixedDeposit
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Fixed_Deposit_Interest_Core_Web_App.BusinessLayer.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AccountNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Balance")
                        .HasColumnType("float");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Account");
                });

            modelBuilder.Entity("Fixed_Deposit_Interest_Core_Web_App.BusinessLayer.Bank", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BankName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("FixedDepositPercentage")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Bank");
                });

            modelBuilder.Entity("Fixed_Deposit_Interest_Core_Web_App.BusinessLayer.CalculatedBalance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfYears")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.ToTable("CalculatedBalance");
                });

            modelBuilder.Entity("Fixed_Deposit_Interest_Core_Web_App.BusinessLayer.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BankId")
                        .HasColumnType("int");

                    b.Property<string>("CustomerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BankId");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("Fixed_Deposit_Interest_Core_Web_App.BusinessLayer.Account", b =>
                {
                    b.HasOne("Fixed_Deposit_Interest_Core_Web_App.BusinessLayer.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Fixed_Deposit_Interest_Core_Web_App.BusinessLayer.CalculatedBalance", b =>
                {
                    b.HasOne("Fixed_Deposit_Interest_Core_Web_App.BusinessLayer.Account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Fixed_Deposit_Interest_Core_Web_App.BusinessLayer.Customer", b =>
                {
                    b.HasOne("Fixed_Deposit_Interest_Core_Web_App.BusinessLayer.Bank", "Bank")
                        .WithMany()
                        .HasForeignKey("BankId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
