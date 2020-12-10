﻿// <auto-generated />
using IT3047Final.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace IT3047Final.Migrations.Trail
{
    [DbContext(typeof(TrailContext))]
    [Migration("20201210183418_Trail-migration")]
    partial class Trailmigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("IT3047Final.Models.Trail", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("parkName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("trailName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("trailRating")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Trails");
                });
#pragma warning restore 612, 618
        }
    }
}
