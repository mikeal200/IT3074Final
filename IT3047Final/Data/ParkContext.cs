using IT3047Final.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IT3047Final.Data
{
    public class ParkContext : DbContext
    {
        public ParkContext(DbContextOptions<ParkContext> options) : base(options)
        {
        }
        public DbSet<Park> Parks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Park>().ToTable("Parks");

            modelBuilder.Entity<Park>()
                .HasData(
                    new Park
                    {
                        ID = 1,
                        parkName = "Keehner Park",
                        parkAddress = "7411 Barret Rd, West Chester Township, OH 45069",
                        parkRating = 3
                    },
                    new Park
                    {
                        ID = 2,
                        parkName = "Carter Park",
                        parkAddress = "1720 King Ave, Kings Mills, OH 45034",
                        parkRating = 3
                    },
                    new Park
                    {
                        ID = 3,
                        parkName = "Hocking Hills State Park",
                        parkAddress = "19852 OH-664, Logan, OH 43138",
                        parkRating = 5
                    },
                    new Park
                    {
                        ID = 4,
                        parkName = "Strouds Run State Park",
                        parkAddress = "11661 State Park Rd, Athens, OH 45701",
                        parkRating = 5
                    },
                    new Park
                    {
                        ID = 5,
                        parkName = "Daniel Boone National Forest",
                        parkAddress = "1700 Bypass Rd, London, KY 40744",
                        parkRating = 5
                    }
                    );
        }
    }
}
