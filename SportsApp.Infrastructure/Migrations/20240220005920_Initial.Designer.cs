﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SportsApp.Infrastructure.DbContext;

#nullable disable

namespace SportsApp.Infrastructure.Migrations
{
    [DbContext(typeof(PlayerDbContext))]
    [Migration("20240220005920_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.27")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SportsApp.Infrastructure.Data.Player.CardEntity", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("Red")
                        .HasColumnType("int");

                    b.Property<int?>("Yellow")
                        .HasColumnType("int");

                    b.Property<int?>("YellowRed")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("CardEntity");
                });

            modelBuilder.Entity("SportsApp.Infrastructure.Data.Player.DribbleEntity", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("Attempts")
                        .HasColumnType("int");

                    b.Property<int?>("Past")
                        .HasColumnType("int");

                    b.Property<int?>("Success")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("DribbleEntity");
                });

            modelBuilder.Entity("SportsApp.Infrastructure.Data.Player.DuelEntity", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("SuccessRate")
                        .HasColumnType("int");

                    b.Property<int?>("Total")
                        .HasColumnType("int");

                    b.Property<int?>("Won")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("DuelEntity");
                });

            modelBuilder.Entity("SportsApp.Infrastructure.Data.Player.FoulEntity", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("Committed")
                        .HasColumnType("int");

                    b.Property<int?>("Drawn")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("FoulEntity");
                });

            modelBuilder.Entity("SportsApp.Infrastructure.Data.Player.GameEntity", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("Appearences")
                        .HasColumnType("int");

                    b.Property<bool?>("Captain")
                        .HasColumnType("bit");

                    b.Property<int?>("Lineups")
                        .HasColumnType("int");

                    b.Property<int?>("Minutes")
                        .HasColumnType("int");

                    b.Property<int?>("Number")
                        .HasColumnType("int");

                    b.Property<string>("Position")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Rating")
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.HasKey("Id");

                    b.ToTable("GameEntity");
                });

            modelBuilder.Entity("SportsApp.Infrastructure.Data.Player.LeagueEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Country")
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("FlagUrl")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LogoUrl")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<int?>("Season")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("LeagueEntity");
                });

            modelBuilder.Entity("SportsApp.Infrastructure.Data.Player.PassEntity", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("Accuracy")
                        .HasColumnType("int");

                    b.Property<int?>("Key")
                        .HasColumnType("int");

                    b.Property<int?>("Total")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("PassEntity");
                });

            modelBuilder.Entity("SportsApp.Infrastructure.Data.Player.PenaltyEntity", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("Committed")
                        .HasColumnType("int");

                    b.Property<int?>("Missed")
                        .HasColumnType("int");

                    b.Property<int?>("Saved")
                        .HasColumnType("int");

                    b.Property<int?>("Scored")
                        .HasColumnType("int");

                    b.Property<int?>("Won")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("PenaltyEntity");
                });

            modelBuilder.Entity("SportsApp.Infrastructure.Data.Player.PlayerEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("Age")
                        .HasColumnType("int");

                    b.Property<DateTime?>("BirtDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("BirthCountry")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("BirthPlace")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("FirstName")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Height")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<bool?>("Injured")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Nationality")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("PhotoUrl")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Weight")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("Id");

                    b.ToTable("Players", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "386",
                            Age = 32,
                            BirthCountry = "Cameroon",
                            BirthPlace = "Some Place",
                            FirstName = "Vincent",
                            Height = "184 cm",
                            Injured = false,
                            LastName = "Aboubakar",
                            Nationality = "Cameroon",
                            PhotoUrl = "https://media.api-sports.io/football/players/386.png",
                            Weight = "75 kg"
                        });
                });

            modelBuilder.Entity("SportsApp.Infrastructure.Data.Player.ShotEntity", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("On")
                        .HasColumnType("int");

                    b.Property<int?>("Total")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ShotEntity");
                });

            modelBuilder.Entity("SportsApp.Infrastructure.Data.Player.StatisticEntity", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CardId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("DribbleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("DuelId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("FoulId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("GameId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LeagueId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<Guid?>("PassId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("PenaltyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PlayerId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<Guid?>("ShotId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("SubstitueId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("TackleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TeamId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("CardId");

                    b.HasIndex("DribbleId");

                    b.HasIndex("DuelId");

                    b.HasIndex("FoulId");

                    b.HasIndex("GameId");

                    b.HasIndex("LeagueId");

                    b.HasIndex("PassId");

                    b.HasIndex("PenaltyId");

                    b.HasIndex("PlayerId");

                    b.HasIndex("ShotId");

                    b.HasIndex("SubstitueId");

                    b.HasIndex("TackleId");

                    b.HasIndex("TeamId");

                    b.ToTable("Statistics", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("c76344af-1844-4b71-8395-e3b57a12bbae")
                        });
                });

            modelBuilder.Entity("SportsApp.Infrastructure.Data.Player.SubstituteEntity", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("Bench")
                        .HasColumnType("int");

                    b.Property<int?>("In")
                        .HasColumnType("int");

                    b.Property<int?>("Out")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("SubstituteEntity");
                });

            modelBuilder.Entity("SportsApp.Infrastructure.Data.Player.TackleEntity", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("Blocks")
                        .HasColumnType("int");

                    b.Property<int?>("Interceptions")
                        .HasColumnType("int");

                    b.Property<int?>("Total")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("TackleEntity");
                });

            modelBuilder.Entity("SportsApp.Infrastructure.Data.Player.TeamEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LogoUrl")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.HasKey("Id");

                    b.ToTable("TeamEntity");
                });

            modelBuilder.Entity("SportsApp.Infrastructure.Data.Player.StatisticEntity", b =>
                {
                    b.HasOne("SportsApp.Infrastructure.Data.Player.CardEntity", "Card")
                        .WithMany()
                        .HasForeignKey("CardId");

                    b.HasOne("SportsApp.Infrastructure.Data.Player.DribbleEntity", "Dribble")
                        .WithMany()
                        .HasForeignKey("DribbleId");

                    b.HasOne("SportsApp.Infrastructure.Data.Player.DuelEntity", "Duel")
                        .WithMany()
                        .HasForeignKey("DuelId");

                    b.HasOne("SportsApp.Infrastructure.Data.Player.FoulEntity", "Foul")
                        .WithMany()
                        .HasForeignKey("FoulId");

                    b.HasOne("SportsApp.Infrastructure.Data.Player.GameEntity", "Game")
                        .WithMany()
                        .HasForeignKey("GameId");

                    b.HasOne("SportsApp.Infrastructure.Data.Player.LeagueEntity", "League")
                        .WithMany()
                        .HasForeignKey("LeagueId");

                    b.HasOne("SportsApp.Infrastructure.Data.Player.PassEntity", "Pass")
                        .WithMany()
                        .HasForeignKey("PassId");

                    b.HasOne("SportsApp.Infrastructure.Data.Player.PenaltyEntity", "Penalty")
                        .WithMany()
                        .HasForeignKey("PenaltyId");

                    b.HasOne("SportsApp.Infrastructure.Data.Player.PlayerEntity", "Player")
                        .WithMany()
                        .HasForeignKey("PlayerId");

                    b.HasOne("SportsApp.Infrastructure.Data.Player.ShotEntity", "Shot")
                        .WithMany()
                        .HasForeignKey("ShotId");

                    b.HasOne("SportsApp.Infrastructure.Data.Player.SubstituteEntity", "Substitute")
                        .WithMany()
                        .HasForeignKey("SubstitueId");

                    b.HasOne("SportsApp.Infrastructure.Data.Player.TackleEntity", "Tackle")
                        .WithMany()
                        .HasForeignKey("TackleId");

                    b.HasOne("SportsApp.Infrastructure.Data.Player.TeamEntity", "Team")
                        .WithMany()
                        .HasForeignKey("TeamId");

                    b.Navigation("Card");

                    b.Navigation("Dribble");

                    b.Navigation("Duel");

                    b.Navigation("Foul");

                    b.Navigation("Game");

                    b.Navigation("League");

                    b.Navigation("Pass");

                    b.Navigation("Penalty");

                    b.Navigation("Player");

                    b.Navigation("Shot");

                    b.Navigation("Substitute");

                    b.Navigation("Tackle");

                    b.Navigation("Team");
                });
#pragma warning restore 612, 618
        }
    }
}
