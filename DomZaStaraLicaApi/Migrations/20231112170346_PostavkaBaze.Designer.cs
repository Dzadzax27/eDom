﻿// <auto-generated />
using System;
using DomZaStaraLicaApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DomZaStaraLicaApi.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231112170346_PostavkaBaze")]
    partial class PostavkaBaze
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DomZaStaraLicaApi.Data.Models.KorisnikDoma", b =>
                {
                    b.Property<int>("KorisnikDomaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KorisnikDomaID"));

                    b.Property<int>("BrojSobe")
                        .HasColumnType("int");

                    b.Property<DateTime>("DatumRodjenja")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImePrezime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("JMBG")
                        .HasColumnType("int");

                    b.Property<int>("OpstinaID")
                        .HasColumnType("int");

                    b.HasKey("KorisnikDomaID");

                    b.HasIndex("OpstinaID");

                    b.ToTable("KorisnikDoma");
                });

            modelBuilder.Entity("DomZaStaraLicaApi.Data.Models.Opstina", b =>
                {
                    b.Property<int>("OpstinaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OpstinaID"));

                    b.Property<int>("PostanskiBroj")
                        .HasColumnType("int");

                    b.HasKey("OpstinaID");

                    b.ToTable("Opstina");
                });

            modelBuilder.Entity("DomZaStaraLicaApi.Data.Models.KorisnikDoma", b =>
                {
                    b.HasOne("DomZaStaraLicaApi.Data.Models.Opstina", "Opstina")
                        .WithMany()
                        .HasForeignKey("OpstinaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Opstina");
                });
#pragma warning restore 612, 618
        }
    }
}
