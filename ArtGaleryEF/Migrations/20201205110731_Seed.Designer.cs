﻿// <auto-generated />
using System;
using ArtGaleryEF.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ArtGaleryEF.Migrations
{
    [DbContext(typeof(ArtContext))]
    [Migration("20201205110731_Seed")]
    partial class Seed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("ArtGaleryEF.Data.Entities.Artist", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("FameStatus")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Artists");

                    b.HasData(
                        new
                        {
                            Id = new Guid("2a8dd830-5d6d-4daa-90c1-1a64d762c513"),
                            FameStatus = 0,
                            FirstName = "Lui",
                            LastName = "Grojan"
                        },
                        new
                        {
                            Id = new Guid("0de3fee1-b15e-49ce-a27b-3e407b2fd22e"),
                            FameStatus = 0,
                            FirstName = "Bart",
                            LastName = "Tompson"
                        },
                        new
                        {
                            Id = new Guid("00647c54-f2d1-44bf-86fc-6aa12293c3e8"),
                            FameStatus = 1,
                            FirstName = "Jorje",
                            LastName = "Vinnor"
                        },
                        new
                        {
                            Id = new Guid("69342729-22f1-4722-923f-61c2767f60b8"),
                            FameStatus = 1,
                            FirstName = "Alex",
                            LastName = "Veltor"
                        },
                        new
                        {
                            Id = new Guid("0458d15a-f5b0-43e3-a9e9-b3111708d4f6"),
                            FameStatus = 1,
                            FirstName = "Elenea",
                            LastName = "Bortwik"
                        });
                });

            modelBuilder.Entity("ArtGaleryEF.Data.Entities.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ArtistId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("PictureId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ArtistId");

                    b.HasIndex("PictureId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("ArtGaleryEF.Data.Entities.Picture", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Pictures");

                    b.HasData(
                        new
                        {
                            Id = new Guid("3af05d14-732f-4229-8a76-a56c761e71a7"),
                            Age = 89,
                            Title = "The Persistence of Memory"
                        },
                        new
                        {
                            Id = new Guid("40642f1a-642c-4a8f-9143-fc3e40349bbf"),
                            Age = 515,
                            Title = "Ritratto di Monna Lisa del Giocondo"
                        },
                        new
                        {
                            Id = new Guid("f158c347-e9b5-40b4-93ad-dfb3ff95f1cf"),
                            Age = 131,
                            Title = "De sterrennacht"
                        },
                        new
                        {
                            Id = new Guid("9772e4c2-2123-49fc-8fcf-5725050e7b8a"),
                            Age = 139,
                            Title = "Богатыри"
                        });
                });

            modelBuilder.Entity("ArtGaleryEF.Data.Entities.Order", b =>
                {
                    b.HasOne("ArtGaleryEF.Data.Entities.Artist", "Artist")
                        .WithMany("Orders")
                        .HasForeignKey("ArtistId");

                    b.HasOne("ArtGaleryEF.Data.Entities.Picture", "Picture")
                        .WithMany("Orders")
                        .HasForeignKey("PictureId");

                    b.Navigation("Artist");

                    b.Navigation("Picture");
                });

            modelBuilder.Entity("ArtGaleryEF.Data.Entities.Artist", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("ArtGaleryEF.Data.Entities.Picture", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
