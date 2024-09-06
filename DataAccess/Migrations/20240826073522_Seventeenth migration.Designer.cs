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
    [Migration("20240826073522_seventeenth migration")]
    partial class Seventeenthmigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DataAccess.Entities.BannedUserEntity", b =>
                {
                    b.Property<string>("User")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Duration")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("User");

                    b.ToTable("BannedUserEntities");
                });

            modelBuilder.Entity("DataAccess.Entities.CommentEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Action")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<Guid>("GameEntityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("GameId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ParentCommentId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("GameEntityId");

                    b.HasIndex("ParentCommentId");

                    b.ToTable("CommentEntities");
                });

            modelBuilder.Entity("DataAccess.Entities.DatabaseIds", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MongoId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DatabaseIdsSet");
                });

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

                    b.Property<DateTime>("PublishDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("PublisherId")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("QuantityPerUnit")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ReorderLevel")
                        .HasColumnType("int");

                    b.Property<int>("UnitInStock")
                        .HasColumnType("int");

                    b.Property<int>("UnitsOnOrder")
                        .HasColumnType("int");

                    b.Property<int>("Views")
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

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<Guid?>("ParentGenreId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Picture")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.HasIndex("ParentGenreId");

                    b.ToTable("GenreEntities");

                    b.HasData(
                        new
                        {
                            Id = new Guid("24a1b221-5ed8-46c4-b474-fdb36af683da"),
                            Description = "",
                            Name = "Strategy",
                            Picture = ""
                        },
                        new
                        {
                            Id = new Guid("1f64b544-6458-4f25-97b7-58fac5d1642b"),
                            Description = "",
                            Name = "RTS",
                            ParentGenreId = new Guid("24a1b221-5ed8-46c4-b474-fdb36af683da"),
                            Picture = ""
                        },
                        new
                        {
                            Id = new Guid("d2830435-cd8c-4726-abd7-5f4e480550ac"),
                            Description = "",
                            Name = "TBS",
                            ParentGenreId = new Guid("24a1b221-5ed8-46c4-b474-fdb36af683da"),
                            Picture = ""
                        },
                        new
                        {
                            Id = new Guid("9a76a6ab-0dc3-4833-bd45-33f65511fffd"),
                            Description = "",
                            Name = "RPG",
                            Picture = ""
                        },
                        new
                        {
                            Id = new Guid("e42692bb-88c0-46d4-a503-cf500f1bbefe"),
                            Description = "",
                            Name = "Sports",
                            Picture = ""
                        },
                        new
                        {
                            Id = new Guid("c974a1f2-36b6-40f4-8b60-c356c3fd9796"),
                            Description = "",
                            Name = "Races",
                            Picture = ""
                        },
                        new
                        {
                            Id = new Guid("e59f8f19-f30a-4d77-bd1b-717457a1f9dc"),
                            Description = "",
                            Name = "Rally",
                            ParentGenreId = new Guid("c974a1f2-36b6-40f4-8b60-c356c3fd9796"),
                            Picture = ""
                        },
                        new
                        {
                            Id = new Guid("19f1001c-95f0-46f2-b9b3-5111519247fe"),
                            Description = "",
                            Name = "Arcade",
                            ParentGenreId = new Guid("c974a1f2-36b6-40f4-8b60-c356c3fd9796"),
                            Picture = ""
                        },
                        new
                        {
                            Id = new Guid("9a0e1900-a0db-4eea-839c-4d93960f1875"),
                            Description = "",
                            Name = "Formula",
                            ParentGenreId = new Guid("c974a1f2-36b6-40f4-8b60-c356c3fd9796"),
                            Picture = ""
                        },
                        new
                        {
                            Id = new Guid("dbed1f1b-f0d1-40bd-b82d-eee04cce2f65"),
                            Description = "",
                            Name = "Off-road",
                            ParentGenreId = new Guid("c974a1f2-36b6-40f4-8b60-c356c3fd9796"),
                            Picture = ""
                        },
                        new
                        {
                            Id = new Guid("e532d529-b9fb-4030-ae1b-bb33f76b94cc"),
                            Description = "",
                            Name = "Action",
                            Picture = ""
                        },
                        new
                        {
                            Id = new Guid("f8cf2cb7-ae47-4eba-9036-9dc638719a17"),
                            Description = "",
                            Name = "FPS",
                            ParentGenreId = new Guid("e532d529-b9fb-4030-ae1b-bb33f76b94cc"),
                            Picture = ""
                        },
                        new
                        {
                            Id = new Guid("1c1d68ed-bcbe-4e73-b423-a4dc6248f598"),
                            Description = "",
                            Name = "TPS",
                            ParentGenreId = new Guid("e532d529-b9fb-4030-ae1b-bb33f76b94cc"),
                            Picture = ""
                        },
                        new
                        {
                            Id = new Guid("c92dd039-465e-46ca-aeba-81b159cee2fe"),
                            Description = "",
                            Name = "Adventure",
                            Picture = ""
                        },
                        new
                        {
                            Id = new Guid("47d66b9a-8133-4ea7-a835-a607c07a56ec"),
                            Description = "",
                            Name = "Puzzle & Skill",
                            Picture = ""
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

                    b.Property<double>("Freight")
                        .HasColumnType("float");

                    b.Property<DateTime>("RequiredDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ShipAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShipCity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShipCountry")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShipName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShipPostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShipRegion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ShipVia")
                        .HasColumnType("int");

                    b.Property<DateTime>("ShippedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("OrderEntities");
                });

            modelBuilder.Entity("DataAccess.Entities.OrderGame", b =>
                {
                    b.Property<Guid>("OrderGameId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Discount")
                        .HasColumnType("int");

                    b.Property<Guid>("OrderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("OrderGameId");

                    b.HasIndex("OrderId");

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

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Title");

                    b.ToTable("PaymentMethods");

                    b.HasData(
                        new
                        {
                            Title = "Bank",
                            Description = "Bank Method Description",
                            ImageUrl = "Bank Method URL"
                        },
                        new
                        {
                            Title = "IBox terminal",
                            Description = "IBox Terminal Method Description",
                            ImageUrl = "IBox Terminal Method URL"
                        },
                        new
                        {
                            Title = "Visa",
                            Description = "Visa Method Description",
                            ImageUrl = "Visa Method URL"
                        });
                });

            modelBuilder.Entity("DataAccess.Entities.PermissionEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PermissionEntities");
                });

            modelBuilder.Entity("DataAccess.Entities.PermissionRole", b =>
                {
                    b.Property<Guid>("PermissionEntityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleEntityId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("PermissionEntityId", "RoleEntityId");

                    b.HasIndex("RoleEntityId");

                    b.ToTable("PermissionRoles");
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
                            Id = new Guid("615fd7bf-5320-44a2-9037-b4eb534d0672"),
                            Type = "Mobile"
                        },
                        new
                        {
                            Id = new Guid("0e635561-c15d-43d3-a6c5-22aa8396915d"),
                            Type = "Browser"
                        },
                        new
                        {
                            Id = new Guid("9cb37129-e684-4174-bcc7-5e98f769ddba"),
                            Type = "Desktop"
                        },
                        new
                        {
                            Id = new Guid("5ac174f0-055f-4e9f-8623-c86a86339329"),
                            Type = "Console"
                        });
                });

            modelBuilder.Entity("DataAccess.Entities.PublisherEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ContactName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fax")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HomePage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CompanyName")
                        .IsUnique();

                    b.ToTable("PublisherEntities");
                });

            modelBuilder.Entity("DataAccess.Entities.RoleEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("RoleEntities");
                });

            modelBuilder.Entity("DataAccess.Entities.UserEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UserEntities");
                });

            modelBuilder.Entity("DataAccess.Entities.UserRole", b =>
                {
                    b.Property<Guid>("RoleEntityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserEntityId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("RoleEntityId", "UserEntityId");

                    b.HasIndex("UserEntityId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("DataAccess.Entities.CommentEntity", b =>
                {
                    b.HasOne("DataAccess.Entities.GameEntity", "GameEntity")
                        .WithMany("CommentEntities")
                        .HasForeignKey("GameEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataAccess.Entities.CommentEntity", "ParentComment")
                        .WithMany()
                        .HasForeignKey("ParentCommentId");

                    b.Navigation("GameEntity");

                    b.Navigation("ParentComment");
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

            modelBuilder.Entity("DataAccess.Entities.PermissionRole", b =>
                {
                    b.HasOne("DataAccess.Entities.PermissionEntity", null)
                        .WithMany()
                        .HasForeignKey("PermissionEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataAccess.Entities.RoleEntity", null)
                        .WithMany()
                        .HasForeignKey("RoleEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DataAccess.Entities.UserRole", b =>
                {
                    b.HasOne("DataAccess.Entities.RoleEntity", null)
                        .WithMany()
                        .HasForeignKey("RoleEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataAccess.Entities.UserEntity", null)
                        .WithMany()
                        .HasForeignKey("UserEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DataAccess.Entities.GameEntity", b =>
                {
                    b.Navigation("CommentEntities");
                });

            modelBuilder.Entity("DataAccess.Entities.PublisherEntity", b =>
                {
                    b.Navigation("GameEntities");
                });
#pragma warning restore 612, 618
        }
    }
}