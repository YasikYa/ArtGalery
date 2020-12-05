using ArtGaleryEF.Data.Entities;
using ArtGaleryEF.Data.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtGaleryEF.Data
{
    public class ArtContext : DbContext
    {
        public ArtContext(DbContextOptions<ArtContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Artist>()
                .HasData(new Artist
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Lui",
                    LastName = "Grojan",
                    FameStatus = Status.Famous
                },
                new Artist
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Bart",
                    LastName = "Tompson",
                    FameStatus = Status.Famous
                },
                new Artist
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Jorje",
                    LastName = "Vinnor",
                    FameStatus = Status.Unfamous
                },
                new Artist
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Alex",
                    LastName = "Veltor",
                    FameStatus = Status.Unfamous
                },
                new Artist
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Elenea",
                    LastName = "Bortwik",
                    FameStatus = Status.Unfamous
                });

            modelBuilder.Entity<Picture>()
                .HasData(new Picture
                {
                    Id = Guid.NewGuid(),
                    Title = "The Persistence of Memory",
                    Age = 89
                },
                new Picture
                {
                    Id = Guid.NewGuid(),
                    Title = "Ritratto di Monna Lisa del Giocondo",
                    Age = 515
                },
                new Picture
                {
                    Id = Guid.NewGuid(),
                    Title = "De sterrennacht",
                    Age = 131
                },
                new Picture
                {
                    Id = Guid.NewGuid(),
                    Title = "Богатыри",
                    Age = 139
                });
        }

        public DbSet<Picture> Pictures { get; set; }

        public DbSet<Artist> Artists { get; set; }

        public DbSet<Order> Orders { get; set; }
    }
}
