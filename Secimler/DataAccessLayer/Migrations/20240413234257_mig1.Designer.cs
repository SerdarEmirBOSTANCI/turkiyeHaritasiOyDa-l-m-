﻿// <auto-generated />
using System;
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20240413234257_mig1")]
    partial class mig1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EntityLayer.Concrete.ikibinonyedisecim", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Kayitlisecmen")
                        .HasColumnType("int");

                    b.Property<int?>("SehirID")
                        .HasColumnType("int");

                    b.Property<double>("evetoyorani")
                        .HasColumnType("float");

                    b.Property<int>("evetoysayisi")
                        .HasColumnType("int");

                    b.Property<int>("gecerlioysayisi")
                        .HasColumnType("int");

                    b.Property<int>("gecersizoysayisi")
                        .HasColumnType("int");

                    b.Property<double>("hayiroyorani")
                        .HasColumnType("float");

                    b.Property<int>("hayiroysayisi")
                        .HasColumnType("int");

                    b.Property<double>("katilimorani")
                        .HasColumnType("float");

                    b.Property<int>("oylayaninsansayisi")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("SehirID");

                    b.ToTable("ikibinonyedisecims");
                });

            modelBuilder.Entity("EntityLayer.Concrete.sehir", b =>
                {
                    b.Property<int>("SehirID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SehirAd")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SehirID");

                    b.ToTable("sehirs");
                });

            modelBuilder.Entity("EntityLayer.Concrete.ikibinonyedisecim", b =>
                {
                    b.HasOne("EntityLayer.Concrete.sehir", "Sehir")
                        .WithMany()
                        .HasForeignKey("SehirID");

                    b.Navigation("Sehir");
                });
#pragma warning restore 612, 618
        }
    }
}
