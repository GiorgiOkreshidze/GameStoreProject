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
    [Migration("20240612193914_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("GameEntities");
                });

            modelBuilder.Entity("DataAccess.Entities.GenreEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ParentGenreId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ParentGenreId");

                    b.ToTable("GenreEntities");

                    b.HasData(
                        new
                        {
                            Id = new Guid("8678fa5c-2ae8-4443-8d26-e4ff10689547"),
                            Name = "Strategy"
                        },
                        new
                        {
                            Id = new Guid("0f444308-dd13-42b1-8cc3-af4ed8e89bd3"),
                            Name = "RTS",
                            ParentGenreId = new Guid("8678fa5c-2ae8-4443-8d26-e4ff10689547")
                        },
                        new
                        {
                            Id = new Guid("b5117a1c-28d3-4d91-a96c-244fb41f20e9"),
                            Name = "TBS",
                            ParentGenreId = new Guid("8678fa5c-2ae8-4443-8d26-e4ff10689547")
                        },
                        new
                        {
                            Id = new Guid("2734ae8a-9dc3-4367-955a-429f425b6198"),
                            Name = "RPG"
                        },
                        new
                        {
                            Id = new Guid("1b8b72f1-042a-429b-ba5c-09697a4fdf72"),
                            Name = "Sports"
                        },
                        new
                        {
                            Id = new Guid("3c33edf2-3698-4000-b1fb-462129d0c954"),
                            Name = "Races"
                        },
                        new
                        {
                            Id = new Guid("66ec2d72-6208-4178-9ea0-9f0c66d98293"),
                            Name = "Rally",
                            ParentGenreId = new Guid("3c33edf2-3698-4000-b1fb-462129d0c954")
                        },
                        new
                        {
                            Id = new Guid("b22e712c-34ce-422f-9fde-614e0d69664f"),
                            Name = "Arcade",
                            ParentGenreId = new Guid("3c33edf2-3698-4000-b1fb-462129d0c954")
                        },
                        new
                        {
                            Id = new Guid("1902c41b-310b-4efc-81c4-7a3ff7820337"),
                            Name = "Formula",
                            ParentGenreId = new Guid("3c33edf2-3698-4000-b1fb-462129d0c954")
                        },
                        new
                        {
                            Id = new Guid("7ae46eee-aa6a-448a-a1c6-d20daa2bc506"),
                            Name = "Off-road",
                            ParentGenreId = new Guid("3c33edf2-3698-4000-b1fb-462129d0c954")
                        },
                        new
                        {
                            Id = new Guid("836301c7-7b07-4dcf-83ec-705b25946c63"),
                            Name = "Action"
                        },
                        new
                        {
                            Id = new Guid("056c55ea-4f32-4a10-b002-615568469c19"),
                            Name = "FPS",
                            ParentGenreId = new Guid("836301c7-7b07-4dcf-83ec-705b25946c63")
                        },
                        new
                        {
                            Id = new Guid("fae914d8-1a86-42c8-992d-f7f12d1138f4"),
                            Name = "TPS",
                            ParentGenreId = new Guid("836301c7-7b07-4dcf-83ec-705b25946c63")
                        },
                        new
                        {
                            Id = new Guid("342fa136-fa19-47e1-96d1-53e75ed85a0e"),
                            Name = "Adventure"
                        },
                        new
                        {
                            Id = new Guid("cd615658-4c0f-4acc-b3c3-9ab3fb7a2bd5"),
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
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PlatformEntities");

                    b.HasData(
                        new
                        {
                            Id = new Guid("90a1e9e8-e3de-4298-a4b3-936c7d99451e"),
                            Type = "Mobile"
                        },
                        new
                        {
                            Id = new Guid("924dc40d-1f67-44dc-af83-aad13124186e"),
                            Type = "Browser"
                        },
                        new
                        {
                            Id = new Guid("4249a843-f8f3-4147-8b9c-8022dc03222e"),
                            Type = "Desktop"
                        },
                        new
                        {
                            Id = new Guid("95e2b27c-3c93-4c7c-95a8-52affc9c04ff"),
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
