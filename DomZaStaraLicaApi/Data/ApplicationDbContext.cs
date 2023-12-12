﻿using Microsoft.EntityFrameworkCore;
using DomZaStaraLicaApi.Data.Models;

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
        public ApplicationDbContext(
            DbContextOptions options) : base(options)
        {
        }
    }
}
