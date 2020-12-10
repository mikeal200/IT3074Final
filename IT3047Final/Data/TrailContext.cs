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

            modelBuilder.Entity<Trail>()
                .HasData(
                    new Trail
                    {
                       ID = 1,
                       trailName = "Van Hook Falls and Cane Creek Valley",
                       parkName = "Daniel Boone National Forest",
                       trailRating = 4
                    },
                    new Trail
                    {
                        ID = 2,
                        trailName = "Gray's Arch Trail Loop",
                        parkName = "Daniel Boone National Forest",
                        trailRating = 4
                    },
                    new Trail
                    {
                        ID = 3,
                        trailName = "Sky Bridge Red River Gorge",
                        parkName = "Daniel Boone National Forest",
                        trailRating = 5
                    },
                    new Trail
                    {
                        ID = 4,
                        trailName = "Double Arch Trail",
                        parkName = "Daniel Boone National Forest",
                        trailRating = 5
                    },
                    new Trail
                    {
                        ID = 5,
                        trailName = "Little Miami Scenic Trail",
                        parkName = "Little Miami State Park",
                        trailRating = 4
                    },
                    new Trail
                    {
                        ID = 6,
                        trailName = "Keehner Park Trail",
                        parkName = "Keehner Park",
                        trailRating = 3
                    },
                    new Trail
                    {
                        ID = 7,
                        trailName = "Pine Trails",
                        parkName = "Pine Hill Park",
                        trailRating = 2
                    }
                    );
        }
    }
}
