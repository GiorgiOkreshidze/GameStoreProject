﻿// <auto-generated />
using System;
using DataAccess.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(GameDbContext))]
    [Migration("20240723090358_Fourth Migration")]
    partial class FourthMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DataAccess.Entities.GameEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Discount")
                        .HasColumnType("int");

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<Guid?>("PublisherId")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("UnitInStock")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Key")
                        .IsUnique();

                    b.HasIndex("PublisherId");

                    b.ToTable("GameEntities");
                });

            modelBuilder.Entity("DataAccess.Entities.GameGenre", b =>
                {
                    b.Property<Guid>("GameEntityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("GenreEntityId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("GameEntityId", "GenreEntityId");

                    b.HasIndex("GenreEntityId");

                    b.ToTable("GameGenres");
                });

            modelBuilder.Entity("DataAccess.Entities.GamePlatform", b =>
                {
                    b.Property<Guid>("GameEntityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PlatformEntityId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("GameEntityId", "PlatformEntityId");

                    b.HasIndex("PlatformEntityId");

                    b.ToTable("GamePlatforms");
                });

            modelBuilder.Entity("DataAccess.Entities.GenreEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<Guid?>("ParentGenreId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.HasIndex("ParentGenreId");

                    b.ToTable("GenreEntities");

                    b.HasData(
                        new
                        {
                            Id = new Guid("5a2e31bc-a552-40c0-bc8d-fbdab228e4a3"),
                            Name = "Strategy"
                        },
                        new
                        {
                            Id = new Guid("444db216-064c-402f-b85c-efb0ccc799d6"),
                            Name = "RTS",
                            ParentGenreId = new Guid("5a2e31bc-a552-40c0-bc8d-fbdab228e4a3")
                        },
                        new
                        {
                            Id = new Guid("f11e9e17-6b99-4c36-ad34-90b4ffdac2cd"),
                            Name = "TBS",
                            ParentGenreId = new Guid("5a2e31bc-a552-40c0-bc8d-fbdab228e4a3")
                        },
                        new
                        {
                            Id = new Guid("8087aa04-a17f-4693-b039-e90f610de819"),
                            Name = "RPG"
                        },
                        new
                        {
                            Id = new Guid("7e487d68-fcc2-4520-920c-4b69b6d88d41"),
                            Name = "Sports"
                        },
                        new
                        {
                            Id = new Guid("377e0f8b-8742-4dc8-bedb-f1fab2c323d5"),
                            Name = "Races"
                        },
                        new
                        {
                            Id = new Guid("7253af67-c104-4cb7-867a-c929ba24a7ea"),
                            Name = "Rally",
                            ParentGenreId = new Guid("377e0f8b-8742-4dc8-bedb-f1fab2c323d5")
                        },
                        new
                        {
                            Id = new Guid("526ccb64-d39c-40ce-965c-0908633737da"),
                            Name = "Arcade",
                            ParentGenreId = new Guid("377e0f8b-8742-4dc8-bedb-f1fab2c323d5")
                        },
                        new
                        {
                            Id = new Guid("7d55723b-290e-49eb-826c-0ed66a7d479e"),
                            Name = "Formula",
                            ParentGenreId = new Guid("377e0f8b-8742-4dc8-bedb-f1fab2c323d5")
                        },
                        new
                        {
                            Id = new Guid("4453160f-dd38-4f69-87bb-c12a1847af4e"),
                            Name = "Off-road",
                            ParentGenreId = new Guid("377e0f8b-8742-4dc8-bedb-f1fab2c323d5")
                        },
                        new
                        {
                            Id = new Guid("9fb95638-a74c-4dd5-9f28-f15a2b122f17"),
                            Name = "Action"
                        },
                        new
                        {
                            Id = new Guid("30e4b92c-83ef-4049-8f57-9d2caa2e3dc2"),
                            Name = "FPS",
                            ParentGenreId = new Guid("9fb95638-a74c-4dd5-9f28-f15a2b122f17")
                        },
                        new
                        {
                            Id = new Guid("da9ff1cb-5978-4023-ad27-dcbf70266282"),
                            Name = "TPS",
                            ParentGenreId = new Guid("9fb95638-a74c-4dd5-9f28-f15a2b122f17")
                        },
                        new
                        {
                            Id = new Guid("611f231d-6252-4914-a579-3dfee9672ae6"),
                            Name = "Adventure"
                        },
                        new
                        {
                            Id = new Guid("dabe0717-c93f-4023-b638-40fa79554705"),
                            Name = "Puzzle & Skill"
                        });
                });

            modelBuilder.Entity("DataAccess.Entities.OrderEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("OrderEntities");
                });

            modelBuilder.Entity("DataAccess.Entities.OrderGame", b =>
                {
                    b.Property<Guid>("OrderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Discount")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("OrderId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderGames");
                });

            modelBuilder.Entity("DataAccess.Entities.PaymentMethod", b =>
                {
                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Title");

                    b.ToTable("PaymentMethods");

                    b.HasData(
                        new
                        {
                            Title = "Bank",
                            Description = "Bank Method Description",
                            Url = "Bank Method URL"
                        },
                        new
                        {
                            Title = "IBox Terminal",
                            Description = "IBox Terminal Method Description",
                            Url = "IBox Terminal Method URL"
                        },
                        new
                        {
                            Title = "Visa",
                            Description = "Visa Method Description",
                            Url = "Visa Method URL"
                        });
                });

            modelBuilder.Entity("DataAccess.Entities.PlatformEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Type")
                        .IsUnique();

                    b.ToTable("PlatformEntities");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ae8d2f3b-9691-48d9-819d-39eced79c0cd"),
                            Type = "Mobile"
                        },
                        new
                        {
                            Id = new Guid("0d3ba892-0eeb-49f3-9d51-eb4a962843e8"),
                            Type = "Browser"
                        },
                        new
                        {
                            Id = new Guid("aa20094e-8f68-47cb-b380-84c83d2939a1"),
                            Type = "Desktop"
                        },
                        new
                        {
                            Id = new Guid("f6bd67fc-9cc7-4649-a333-8f30467644b3"),
                            Type = "Console"
                        });
                });

            modelBuilder.Entity("DataAccess.Entities.PublisherEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HomePage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CompanyName")
                        .IsUnique();

                    b.ToTable("PublisherEntities");
                });

            modelBuilder.Entity("DataAccess.Entities.GameEntity", b =>
                {
                    b.HasOne("DataAccess.Entities.PublisherEntity", "PublisherEntity")
                        .WithMany("GameEntities")
                        .HasForeignKey("PublisherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PublisherEntity");
                });

            modelBuilder.Entity("DataAccess.Entities.GameGenre", b =>
                {
                    b.HasOne("DataAccess.Entities.GameEntity", null)
                        .WithMany()
                        .HasForeignKey("GameEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataAccess.Entities.GenreEntity", null)
                        .WithMany()
                        .HasForeignKey("GenreEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DataAccess.Entities.GamePlatform", b =>
                {
                    b.HasOne("DataAccess.Entities.GameEntity", null)
                        .WithMany()
                        .HasForeignKey("GameEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataAccess.Entities.PlatformEntity", null)
                        .WithMany()
                        .HasForeignKey("PlatformEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DataAccess.Entities.GenreEntity", b =>
                {
                    b.HasOne("DataAccess.Entities.GenreEntity", "ParentGenre")
                        .WithMany()
                        .HasForeignKey("ParentGenreId");

                    b.Navigation("ParentGenre");
                });

            modelBuilder.Entity("DataAccess.Entities.OrderGame", b =>
                {
                    b.HasOne("DataAccess.Entities.OrderEntity", null)
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataAccess.Entities.GameEntity", null)
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DataAccess.Entities.PublisherEntity", b =>
                {
                    b.Navigation("GameEntities");
                });
#pragma warning restore 612, 618
        }
    }
}
