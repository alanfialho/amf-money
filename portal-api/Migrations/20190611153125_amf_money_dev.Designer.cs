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
    [Migration("20190611153125_amf_money_dev")]
    partial class amf_money_dev
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

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

                    b.Property<sbyte>("RiskGainRelationship")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.ToTable("TradingBooks");
                });
#pragma warning restore 612, 618
        }
    }
}
