using Microsoft.EntityFrameworkCore;
using IT3047Final.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IT3047Final.Data
{
    public class TrailContext : DbContext
    { 
        public TrailContext(DbContextOptions<TrailContext> options) : base(options)
        {
        }
        public DbSet<Trail> Trails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Trail>().ToTable("Trails");
        }
    }
}
