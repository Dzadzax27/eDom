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
    [Migration("20231115125812_dodajDoktora")]
    partial class dodajDoktora
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DomZaStaraLicaApi.Data.Models.KorisnickiNalog", b =>
                {
                    b.Property<int>("NalogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NalogId"));

                    b.Property<bool>("JeAdmin")
                        .HasColumnType("bit");

                    b.Property<bool>("JeDoktor")
                        .HasColumnType("bit");

                    b.Property<bool>("JeFizioterapeut")
                        .HasColumnType("bit");

                    b.Property<bool>("JeNjegovatelj")
                        .HasColumnType("bit");

                    b.Property<bool>("JeNutricionista")
                        .HasColumnType("bit");

                    b.Property<string>("KorisnickoIme")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lozinka")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NalogId");

                    b.ToTable("KorisnickiNalog");
                });

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

                    b.Property<string>("JMBG")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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

                    b.Property<string>("NazivOpstine")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PostanskiBroj")
                        .HasColumnType("int");

                    b.HasKey("OpstinaID");

                    b.ToTable("Opstina");
                });

            modelBuilder.Entity("DomZaStaraLicaApi.Data.Models.PoslovnaPozicija", b =>
                {
                    b.Property<int>("PoslovnaPozicijaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PoslovnaPozicijaId"));

                    b.Property<int>("BrojSati")
                        .HasColumnType("int");

                    b.Property<string>("OpisPosla")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Zvanje")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PoslovnaPozicijaId");

                    b.ToTable("PoslovnaPozicija");
                });

            modelBuilder.Entity("DomZaStaraLicaApi.Data.Models.Zaposlenik", b =>
                {
                    b.Property<int>("ZaposlenikId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ZaposlenikId"));

                    b.Property<DateTime>("DatumRodjenja")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DatumZaposlenja")
                        .HasColumnType("datetime2");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImePrezime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JMBG")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NalogId")
                        .HasColumnType("int");

                    b.Property<int>("PoslovnaPozicijaId")
                        .HasColumnType("int");

                    b.HasKey("ZaposlenikId");

                    b.HasIndex("NalogId");

                    b.HasIndex("PoslovnaPozicijaId");

                    b.ToTable("Zaposlenik");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Zaposlenik");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("DomZaStaraLicaApi.Data.Models.Doktor", b =>
                {
                    b.HasBaseType("DomZaStaraLicaApi.Data.Models.Zaposlenik");

                    b.Property<string>("NazivKlinike")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OblastMedicine")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Specijalizacija")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Doktor");
                });

            modelBuilder.Entity("DomZaStaraLicaApi.Data.Models.Njegovatelj", b =>
                {
                    b.HasBaseType("DomZaStaraLicaApi.Data.Models.Zaposlenik");

                    b.Property<int>("brojPacijenata")
                        .HasColumnType("int");

                    b.Property<bool>("isMedicinskiTehnicar")
                        .HasColumnType("bit");

                    b.Property<bool>("isNjegovatelj")
                        .HasColumnType("bit");

                    b.HasDiscriminator().HasValue("Njegovatelj");
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

            modelBuilder.Entity("DomZaStaraLicaApi.Data.Models.Zaposlenik", b =>
                {
                    b.HasOne("DomZaStaraLicaApi.Data.Models.KorisnickiNalog", "KorisnickiNalog")
                        .WithMany()
                        .HasForeignKey("NalogId");

                    b.HasOne("DomZaStaraLicaApi.Data.Models.PoslovnaPozicija", "PoslovnaPozicija")
                        .WithMany()
                        .HasForeignKey("PoslovnaPozicijaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KorisnickiNalog");

                    b.Navigation("PoslovnaPozicija");
                });
#pragma warning restore 612, 618
        }
    }
}
