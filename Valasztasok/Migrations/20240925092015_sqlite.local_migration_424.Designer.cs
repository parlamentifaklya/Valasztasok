﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Valasztasok.Models;

#nullable disable

namespace Valasztasok.Migrations
{
    [DbContext(typeof(ValasztasDbContext))]
    [Migration("20240925092015_sqlite.local_migration_424")]
    partial class sqlitelocal_migration_424
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("Valasztasok.Models.Jelolt", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Kerulet")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nev")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PartRovidNev")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("SzavazatokSzama")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("PartRovidNev");

                    b.ToTable("Jeloltek");
                });

            modelBuilder.Entity("Valasztasok.Models.Part", b =>
                {
                    b.Property<string>("RovidNev")
                        .HasColumnType("TEXT");

                    b.Property<string>("HosszuNev")
                        .HasColumnType("TEXT");

                    b.HasKey("RovidNev");

                    b.ToTable("Partok");
                });

            modelBuilder.Entity("Valasztasok.Models.Jelolt", b =>
                {
                    b.HasOne("Valasztasok.Models.Part", "Part")
                        .WithMany("Jeloltek")
                        .HasForeignKey("PartRovidNev")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Part");
                });

            modelBuilder.Entity("Valasztasok.Models.Part", b =>
                {
                    b.Navigation("Jeloltek");
                });
#pragma warning restore 612, 618
        }
    }
}
