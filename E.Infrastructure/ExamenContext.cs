using E.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace E.Infrastructure
{
    public class ExamenContext:DbContext
    {


        public DbSet<Agent> Agents { get; set; }
        public DbSet<Entreprise> Entrepeises { get; set; }
        public DbSet<Locataire> Locataires { get; set; }
        public DbSet<Personne> Personnes { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Vehicule> Vehicules { get; set; }
        



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DAGDEG;
    Initial Catalog=AyedMedAziz;Integrated Security=true;
    User ID=Azyyzme01; Password=5865088055176941;TrustServerCertificate=True;");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Locataire>().HasMany(p => p.Reservations)
               .WithOne(r => r.Locataire).HasForeignKey(p => p.LocataireKey);

            modelBuilder.Entity<Reservation>().HasOne(r => r.Vehicule)
                .WithMany(t => t.Reservations).HasForeignKey(p => p.VehiculeKey);

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Locataire>()
                .HasDiscriminator<int>("PassengerType")
                .HasValue<Locataire>(0)
                .HasValue<Entreprise>(1)
                .HasValue<Personne>(2);
        }







        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            base.ConfigureConventions(configurationBuilder);
        }
    }
}
