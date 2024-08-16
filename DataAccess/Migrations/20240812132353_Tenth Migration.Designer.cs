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
    [Migration("20240812132353_Tenth Migration")]
    partial class TenthMigration
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

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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
                            Id = new Guid("80fed641-b822-4718-8ca8-15da6b61fb2b"),
                            Description = "",
                            Name = "Strategy",
                            Picture = ""
                        },
                        new
                        {
                            Id = new Guid("acf85088-2604-4066-a554-dd91aaad5856"),
                            Description = "",
                            Name = "RTS",
                            ParentGenreId = new Guid("80fed641-b822-4718-8ca8-15da6b61fb2b"),
                            Picture = ""
                        },
                        new
                        {
                            Id = new Guid("556cd4fd-78c2-42be-8f96-074b266f9372"),
                            Description = "",
                            Name = "TBS",
                            ParentGenreId = new Guid("80fed641-b822-4718-8ca8-15da6b61fb2b"),
                            Picture = ""
                        },
                        new
                        {
                            Id = new Guid("9bbe051e-c76c-4768-b104-3a7fdd66506a"),
                            Description = "",
                            Name = "RPG",
                            Picture = ""
                        },
                        new
                        {
                            Id = new Guid("d598350e-d7d2-4851-afbd-ee84428ec7a7"),
                            Description = "",
                            Name = "Sports",
                            Picture = ""
                        },
                        new
                        {
                            Id = new Guid("bce50724-9419-472c-9d43-e0e7436b9678"),
                            Description = "",
                            Name = "Races",
                            Picture = ""
                        },
                        new
                        {
                            Id = new Guid("1c152611-98b7-46e3-b9b4-1ef88f92589f"),
                            Description = "",
                            Name = "Rally",
                            ParentGenreId = new Guid("bce50724-9419-472c-9d43-e0e7436b9678"),
                            Picture = ""
                        },
                        new
                        {
                            Id = new Guid("b961e2bf-f34c-45ec-9cf5-0db2f4b04c6e"),
                            Description = "",
                            Name = "Arcade",
                            ParentGenreId = new Guid("bce50724-9419-472c-9d43-e0e7436b9678"),
                            Picture = ""
                        },
                        new
                        {
                            Id = new Guid("1fb5c57f-3589-4af7-a107-09d653ee4bbf"),
                            Description = "",
                            Name = "Formula",
                            ParentGenreId = new Guid("bce50724-9419-472c-9d43-e0e7436b9678"),
                            Picture = ""
                        },
                        new
                        {
                            Id = new Guid("b42aa2fb-f03f-44bb-abc0-7920b4c76104"),
                            Description = "",
                            Name = "Off-road",
                            ParentGenreId = new Guid("bce50724-9419-472c-9d43-e0e7436b9678"),
                            Picture = ""
                        },
                        new
                        {
                            Id = new Guid("948cee7b-b6fb-44a6-b4e7-598bce096b30"),
                            Description = "",
                            Name = "Action",
                            Picture = ""
                        },
                        new
                        {
                            Id = new Guid("6e3a8446-0c24-4854-85d1-8ab0a5119d99"),
                            Description = "",
                            Name = "FPS",
                            ParentGenreId = new Guid("948cee7b-b6fb-44a6-b4e7-598bce096b30"),
                            Picture = ""
                        },
                        new
                        {
                            Id = new Guid("5d87f2dc-8c65-4a54-8647-6405b7b788eb"),
                            Description = "",
                            Name = "TPS",
                            ParentGenreId = new Guid("948cee7b-b6fb-44a6-b4e7-598bce096b30"),
                            Picture = ""
                        },
                        new
                        {
                            Id = new Guid("a3b13d1c-d407-4ce4-bec6-6c3b10482bb5"),
                            Description = "",
                            Name = "Adventure",
                            Picture = ""
                        },
                        new
                        {
                            Id = new Guid("03ebd16b-ee06-467f-b436-a3e0e92a3475"),
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
                            Id = new Guid("96629d81-cc69-4542-91f5-7b6abf52f1dd"),
                            Type = "Mobile"
                        },
                        new
                        {
                            Id = new Guid("2fec40db-be43-4bef-84b0-2987a0847035"),
                            Type = "Browser"
                        },
                        new
                        {
                            Id = new Guid("5c2ce715-850c-4f36-adcb-123d308d2ecf"),
                            Type = "Desktop"
                        },
                        new
                        {
                            Id = new Guid("31bed5a7-481a-44bd-8723-a7805e9aa8ac"),
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
