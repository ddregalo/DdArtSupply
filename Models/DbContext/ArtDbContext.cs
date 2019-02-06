namespace DdArtSupply.Models.DbContext
{
    using System;
    using System.Data.SQLite;
    using Microsoft.EntityFrameworkCore;

    public class ArtDbContext : DbContext
    {
        public ArtDbContext(DbContextOptions<ArtDbContext> options) :base(options)
        { }

        public DbSet<Art> Artworks { get; set; }
    }
}