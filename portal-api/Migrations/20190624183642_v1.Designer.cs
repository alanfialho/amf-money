﻿// <auto-generated />
using System;
using AmfValor.AmfMoney.PortalApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AmfValor.AmfMoney.PortalApi.Migrations
{
    [DbContext(typeof(AmfMoneyContext))]
    [Migration("20190624183642_v1")]
    partial class v1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AmfValor.AmfMoney.PortalApi.Model.Trade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Asset")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("OperationType")
                        .IsRequired()
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 1)));

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int>("Quantity");

                    b.Property<decimal>("StopGain")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<decimal>("StopLoss")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int?>("TradingBookId");

                    b.HasKey("Id");

                    b.HasIndex("TradingBookId");

                    b.ToTable("Trades");
                });

            modelBuilder.Entity("AmfValor.AmfMoney.PortalApi.Model.TradingBook", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("AmountPerCaptal")
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 38, scale: 17)))
                        .HasColumnType("decimal(2,2)");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<decimal>("RiskPerTrade")
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 38, scale: 17)))
                        .HasColumnType("decimal(2,2)");

                    b.Property<sbyte>("RiskRewardRatio")
                        .HasColumnType("tinyint(1)");

                    b.Property<decimal>("TotalCaptal")
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 38, scale: 17)))
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("TradingBooks");
                });

            modelBuilder.Entity("AmfValor.AmfMoney.PortalApi.Model.Trade", b =>
                {
                    b.HasOne("AmfValor.AmfMoney.PortalApi.Model.TradingBook")
                        .WithMany("Trades")
                        .HasForeignKey("TradingBookId");
                });
#pragma warning restore 612, 618
        }
    }
}
