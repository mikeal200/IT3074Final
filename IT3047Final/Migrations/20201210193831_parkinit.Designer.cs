﻿// <auto-generated />
using IT3047Final.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace IT3047Final.Migrations
{
    [DbContext(typeof(ParkContext))]
    [Migration("20201210193831_parkinit")]
    partial class parkinit
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("IT3047Final.Models.Park", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("parkAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("parkName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("parkRating")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Parks");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            parkAddress = "7411 Barret Rd, West Chester Township, OH 45069",
                            parkName = "Keehner Park",
                            parkRating = 3
                        },
                        new
                        {
                            ID = 2,
                            parkAddress = "1720 King Ave, Kings Mills, OH 45034",
                            parkName = "Carter Park",
                            parkRating = 3
                        },
                        new
                        {
                            ID = 3,
                            parkAddress = "19852 OH-664, Logan, OH 43138",
                            parkName = "Hocking Hills State Park",
                            parkRating = 5
                        },
                        new
                        {
                            ID = 4,
                            parkAddress = "11661 State Park Rd, Athens, OH 45701",
                            parkName = "Strouds Run State Park",
                            parkRating = 5
                        },
                        new
                        {
                            ID = 5,
                            parkAddress = "1700 Bypass Rd, London, KY 40744",
                            parkName = "Daniel Boone National Forest",
                            parkRating = 5
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
