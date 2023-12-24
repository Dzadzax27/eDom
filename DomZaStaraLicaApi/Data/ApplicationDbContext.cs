﻿using DomZaStaraLicaApi.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace DomZaStaraLicaApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<KorisnikDoma> KorisnikDoma { get; set; }

        public DbSet<Opstina> Opstina { get; set; }
        public DbSet<KorisnickiNalog> KorisnickiNalog { get; set; }
        public DbSet<PoslovnaPozicija> PoslovnaPozicija { get; set; }
        public DbSet<Zaposlenik> Zaposlenik { get; set; }
        public DbSet<Njegovatelj> Njegovatelj { get; set; }
        public DbSet<Doktor> Doktor { get; set; }
        public DbSet<Nutricionista> Nutricionista { get; set; }
        public DbSet<Fizioterapeut> Fizioterapeut { get; set; }
        public DbSet<AuthToken> AuthToken { get; set; }
        public DbSet<Dijagnoza> Dijagnoza { get; set; }
        public DbSet<CLijek> Lijek { get; set; }
        public DbSet<Terapija> Terapija { get; set; }
        public DbSet<TerapijaLijek> TerapijaLijek { get; set; }
        public DbSet<Napomena> Napomena { get; set; }
        public DbSet<VrstaNapomene> VrstaNapomene { get; set; }


        public ApplicationDbContext(
            DbContextOptions options) : base(options)
        {
        }

    }
}
