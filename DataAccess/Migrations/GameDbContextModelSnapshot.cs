﻿// <auto-generated />
using System;
using DataAccess.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(GameDbContext))]
    partial class GameDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0-preview.5.24306.3")
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

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Key")
                        .IsUnique();

                    b.ToTable("GameEntities");
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
                            Id = new Guid("e6b02ab2-12a7-4105-ac60-f388186f8c71"),
                            Name = "Strategy"
                        },
                        new
                        {
                            Id = new Guid("7aa18673-2b49-4c0a-824c-774e5cc4147f"),
                            Name = "RTS",
                            ParentGenreId = new Guid("e6b02ab2-12a7-4105-ac60-f388186f8c71")
                        },
                        new
                        {
                            Id = new Guid("55a74458-3aa5-4aa0-aced-1aca041edc8c"),
                            Name = "TBS",
                            ParentGenreId = new Guid("e6b02ab2-12a7-4105-ac60-f388186f8c71")
                        },
                        new
                        {
                            Id = new Guid("7a5d9ca3-2a8b-4c22-923b-b9f08432e8c4"),
                            Name = "RPG"
                        },
                        new
                        {
                            Id = new Guid("86921cfe-7eed-4fe1-8171-c315825ff38b"),
                            Name = "Sports"
                        },
                        new
                        {
                            Id = new Guid("2664d92e-382b-4ce7-be57-5beacb642aaf"),
                            Name = "Races"
                        },
                        new
                        {
                            Id = new Guid("4598a335-3f58-459e-bc10-044d2f121f8e"),
                            Name = "Rally",
                            ParentGenreId = new Guid("2664d92e-382b-4ce7-be57-5beacb642aaf")
                        },
                        new
                        {
                            Id = new Guid("d58d611e-ecdf-4b15-911a-cfcc1417e3ba"),
                            Name = "Arcade",
                            ParentGenreId = new Guid("2664d92e-382b-4ce7-be57-5beacb642aaf")
                        },
                        new
                        {
                            Id = new Guid("7744e708-10db-4a68-b002-9eedc1195e18"),
                            Name = "Formula",
                            ParentGenreId = new Guid("2664d92e-382b-4ce7-be57-5beacb642aaf")
                        },
                        new
                        {
                            Id = new Guid("8d8115c3-fe7a-4b2d-80c2-56358fd7daeb"),
                            Name = "Off-road",
                            ParentGenreId = new Guid("2664d92e-382b-4ce7-be57-5beacb642aaf")
                        },
                        new
                        {
                            Id = new Guid("ecb19068-a2db-4eb2-b871-0664e3e23b96"),
                            Name = "Action"
                        },
                        new
                        {
                            Id = new Guid("05c723dd-dfb5-4e2a-8ef2-2a3f2a0e0258"),
                            Name = "FPS",
                            ParentGenreId = new Guid("ecb19068-a2db-4eb2-b871-0664e3e23b96")
                        },
                        new
                        {
                            Id = new Guid("68344482-1cf7-47a8-8133-4d896cd60ffc"),
                            Name = "TPS",
                            ParentGenreId = new Guid("ecb19068-a2db-4eb2-b871-0664e3e23b96")
                        },
                        new
                        {
                            Id = new Guid("690d7e38-2752-4b79-9b7b-3d5e218cd9bd"),
                            Name = "Adventure"
                        },
                        new
                        {
                            Id = new Guid("8096feab-2415-4b4b-82b9-c37e0f367535"),
                            Name = "Puzzle & Skill"
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
                            Id = new Guid("cf6fb34c-ac9a-4af9-aaf2-2a4e3f0a4790"),
                            Type = "Mobile"
                        },
                        new
                        {
                            Id = new Guid("8dfd6dce-51c7-464e-939b-6c0170bf954f"),
                            Type = "Browser"
                        },
                        new
                        {
                            Id = new Guid("c10e61e0-dc44-4195-80f3-e227b51b3586"),
                            Type = "Desktop"
                        },
                        new
                        {
                            Id = new Guid("34ef5e1c-cefa-499a-b770-da4752ecf826"),
                            Type = "Console"
                        });
                });

            modelBuilder.Entity("GameEntityGenreEntity", b =>
                {
                    b.Property<Guid>("GameEntitiesId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("GenreEntitiesId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("GameEntitiesId", "GenreEntitiesId");

                    b.HasIndex("GenreEntitiesId");

                    b.ToTable("GameGenre", (string)null);
                });

            modelBuilder.Entity("GameEntityPlatformEntity", b =>
                {
                    b.Property<Guid>("GameEntitiesId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PlatformEntitiesId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("GameEntitiesId", "PlatformEntitiesId");

                    b.HasIndex("PlatformEntitiesId");

                    b.ToTable("GamePlatform", (string)null);
                });

            modelBuilder.Entity("DataAccess.Entities.GenreEntity", b =>
                {
                    b.HasOne("DataAccess.Entities.GenreEntity", "ParentGenre")
                        .WithMany()
                        .HasForeignKey("ParentGenreId");

                    b.Navigation("ParentGenre");
                });

            modelBuilder.Entity("GameEntityGenreEntity", b =>
                {
                    b.HasOne("DataAccess.Entities.GameEntity", null)
                        .WithMany()
                        .HasForeignKey("GameEntitiesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataAccess.Entities.GenreEntity", null)
                        .WithMany()
                        .HasForeignKey("GenreEntitiesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GameEntityPlatformEntity", b =>
                {
                    b.HasOne("DataAccess.Entities.GameEntity", null)
                        .WithMany()
                        .HasForeignKey("GameEntitiesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataAccess.Entities.PlatformEntity", null)
                        .WithMany()
                        .HasForeignKey("PlatformEntitiesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
