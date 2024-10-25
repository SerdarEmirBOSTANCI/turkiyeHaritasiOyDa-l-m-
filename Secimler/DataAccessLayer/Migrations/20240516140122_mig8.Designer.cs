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
    [Migration("20240516140122_mig8")]
    partial class mig8
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EntityLayer.Concrete.denemeicin", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("MA")
                        .HasColumnType("float");

                    b.Property<double>("MI")
                        .HasColumnType("float");

                    b.Property<double>("RTE")
                        .HasColumnType("float");

                    b.Property<double>("SD")
                        .HasColumnType("float");

                    b.HasKey("ID");

                    b.ToTable("denemeicins");
                });

            modelBuilder.Entity("EntityLayer.Concrete.ikibinondortsecim", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("EIaldiğioy")
                        .HasColumnType("float");

                    b.Property<double>("EIoyorani")
                        .HasColumnType("float");

                    b.Property<double>("RTEaldiğioy")
                        .HasColumnType("float");

                    b.Property<double>("RTEoyorani")
                        .HasColumnType("float");

                    b.Property<double>("SDaldiğioy")
                        .HasColumnType("float");

                    b.Property<double>("SDoyorani")
                        .HasColumnType("float");

                    b.Property<string>("SehirAd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SehirID")
                        .HasColumnType("int");

                    b.Property<double>("Toplamoy")
                        .HasColumnType("float");

                    b.HasKey("ID");

                    b.HasIndex("SehirID");

                    b.ToTable("İkibinondortsecims");
                });

            modelBuilder.Entity("EntityLayer.Concrete.ikibinonsekizsecim", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("DP")
                        .HasColumnType("float");

                    b.Property<double>("MA")
                        .HasColumnType("float");

                    b.Property<double>("MI")
                        .HasColumnType("float");

                    b.Property<double>("RTE")
                        .HasColumnType("float");

                    b.Property<double>("SD")
                        .HasColumnType("float");

                    b.Property<string>("SehirAd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SehirID")
                        .HasColumnType("int");

                    b.Property<double>("TK")
                        .HasColumnType("float");

                    b.HasKey("ID");

                    b.HasIndex("SehirID");

                    b.ToTable("ikibinonsekizsecims");
                });

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

            modelBuilder.Entity("EntityLayer.Concrete.ikibinyirmiucsecimbir", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("KK")
                        .HasColumnType("float");

                    b.Property<double>("MI")
                        .HasColumnType("float");

                    b.Property<double>("RTE")
                        .HasColumnType("float");

                    b.Property<double>("SO")
                        .HasColumnType("float");

                    b.Property<string>("SehirAd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SehirID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("SehirID");

                    b.ToTable("ikibinyirmiucsecimbirs");
                });

            modelBuilder.Entity("EntityLayer.Concrete.ikibinyirmiucsecimiki", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("KK")
                        .HasColumnType("float");

                    b.Property<double>("RTE")
                        .HasColumnType("float");

                    b.Property<string>("SehirAd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SehirID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("SehirID");

                    b.ToTable("ikibinyirmiucsecimikis");
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

            modelBuilder.Entity("EntityLayer.Concrete.ikibinondortsecim", b =>
                {
                    b.HasOne("EntityLayer.Concrete.sehir", "Sehir")
                        .WithMany()
                        .HasForeignKey("SehirID");

                    b.Navigation("Sehir");
                });

            modelBuilder.Entity("EntityLayer.Concrete.ikibinonsekizsecim", b =>
                {
                    b.HasOne("EntityLayer.Concrete.sehir", "Sehir")
                        .WithMany()
                        .HasForeignKey("SehirID");

                    b.Navigation("Sehir");
                });

            modelBuilder.Entity("EntityLayer.Concrete.ikibinonyedisecim", b =>
                {
                    b.HasOne("EntityLayer.Concrete.sehir", "Sehir")
                        .WithMany("ikibinonyedisecims")
                        .HasForeignKey("SehirID");

                    b.Navigation("Sehir");
                });

            modelBuilder.Entity("EntityLayer.Concrete.ikibinyirmiucsecimbir", b =>
                {
                    b.HasOne("EntityLayer.Concrete.sehir", "Sehir")
                        .WithMany()
                        .HasForeignKey("SehirID");

                    b.Navigation("Sehir");
                });

            modelBuilder.Entity("EntityLayer.Concrete.ikibinyirmiucsecimiki", b =>
                {
                    b.HasOne("EntityLayer.Concrete.sehir", "Sehir")
                        .WithMany()
                        .HasForeignKey("SehirID");

                    b.Navigation("Sehir");
                });

            modelBuilder.Entity("EntityLayer.Concrete.sehir", b =>
                {
                    b.Navigation("ikibinonyedisecims");
                });
#pragma warning restore 612, 618
        }
    }
}
