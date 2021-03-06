// <auto-generated />
using System;
using MyWallet.Infrastructure.EntityFrameworkDataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MyWallet.Infrastructure.EntityFrameworkDataAccess.Migrations
{
    [DbContext(typeof(MyWalletContext))]
    [Migration("20181111112931_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MyWallet.Infrastructure.EntityFrameworkDataAccess.Entities.Account", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("CustomerId");

                    b.HasKey("Id");

                    b.ToTable("Account");
                });

            modelBuilder.Entity("MyWallet.Infrastructure.EntityFrameworkDataAccess.Entities.Credit", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("AccountId");

                    b.Property<decimal>("Amount");

                    b.Property<DateTime>("TransactionDate");

                    b.HasKey("Id");

                    b.ToTable("Credit");
                });

            modelBuilder.Entity("MyWallet.Infrastructure.EntityFrameworkDataAccess.Entities.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("SSN");

                    b.HasKey("Id");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("MyWallet.Infrastructure.EntityFrameworkDataAccess.Entities.Debit", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("AccountId");

                    b.Property<decimal>("Amount");

                    b.Property<DateTime>("TransactionDate");

                    b.HasKey("Id");

                    b.ToTable("Debit");
                });
#pragma warning restore 612, 618
        }
    }
}
