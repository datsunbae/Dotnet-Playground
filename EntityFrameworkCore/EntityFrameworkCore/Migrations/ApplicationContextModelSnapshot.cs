﻿// <auto-generated />
using System;
using EntityFrameworkCore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EntityFrameworkCore.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EntityFrameworkCore.Entities.Student", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = new Guid("41b59623-549d-4bee-b055-ad6fcb98ccb6"),
                            Address = "Binh Tan, HCM",
                            Age = 18,
                            Name = "Datsunbae"
                        },
                        new
                        {
                            Id = new Guid("daa362be-7555-471b-9afd-1e578d5ffb87"),
                            Address = "Go Vap, HCM",
                            Age = 20,
                            Name = "Kodoku"
                        },
                        new
                        {
                            Id = new Guid("c262da4f-6a04-484c-8996-21eb92f8aa05"),
                            Address = "Go Vap, HCM",
                            Age = 21,
                            Name = "Van Dat"
                        },
                        new
                        {
                            Id = new Guid("c2df7bd2-1f47-4c60-a482-b936604a550c"),
                            Address = "USA",
                            Age = 21,
                            Name = "Justin"
                        },
                        new
                        {
                            Id = new Guid("f02d37be-f61f-4212-87b4-5fb4a4f79ae0"),
                            Address = "USA",
                            Age = 22,
                            Name = "Ronaldo"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
