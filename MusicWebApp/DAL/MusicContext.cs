using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MusicWebApp.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MusicWebApp.DAL
{
    public class MusicContext : DbContext
    {
        public MusicContext() : base("MusicContext")
        {
        }

        public DbSet<Artist> Artist { get; set; }
        public DbSet<Genre> Genre { get; set; }
        public DbSet<Album> Album { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}