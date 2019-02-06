﻿// <auto-generated />
using DdArtSupply.Models.DbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DdArtSupply.Migrations
{
    [DbContext(typeof(ArtDbContext))]
    [Migration("20190204234315_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DdArtSupply.Models.Art", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Collection");

                    b.Property<int>("Height");

                    b.Property<string>("ImageSource");

                    b.Property<string>("Medium");

                    b.Property<int>("Price");

                    b.Property<string>("Title");

                    b.Property<int>("Width");

                    b.Property<int>("Year");

                    b.HasKey("Id");

                    b.ToTable("Artworks");
                });
#pragma warning restore 612, 618
        }
    }
}
