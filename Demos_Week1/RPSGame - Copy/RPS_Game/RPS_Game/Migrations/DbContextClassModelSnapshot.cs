﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RPS_Game.Models;

namespace RPS_Game.Migrations
{
    [DbContext(typeof(DbContextClass))]
    partial class DbContextClassModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0-preview.3.20181.2");

            modelBuilder.Entity("RPS_Game.Models.Game", b =>
                {
                    b.Property<int>("GameId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("WinnerPlayerId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("p1PlayerId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("p2PlayerId")
                        .HasColumnType("INTEGER");

                    b.HasKey("GameId");

                    b.HasIndex("WinnerPlayerId");

                    b.HasIndex("p1PlayerId");

                    b.HasIndex("p2PlayerId");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("RPS_Game.Models.Player", b =>
                {
                    b.Property<int>("PlayerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Losses")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("Wins")
                        .HasColumnType("INTEGER");

                    b.HasKey("PlayerId");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("RPS_Game.Models.Round", b =>
                {
                    b.Property<int>("RoundId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("GameId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("WinnerPlayerId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("p1Choice")
                        .HasColumnType("TEXT");

                    b.Property<string>("p2Choice")
                        .HasColumnType("TEXT");

                    b.HasKey("RoundId");

                    b.HasIndex("GameId");

                    b.HasIndex("WinnerPlayerId");

                    b.ToTable("Rounds");
                });

            modelBuilder.Entity("RPS_Game.Models.Game", b =>
                {
                    b.HasOne("RPS_Game.Models.Player", "Winner")
                        .WithMany()
                        .HasForeignKey("WinnerPlayerId");

                    b.HasOne("RPS_Game.Models.Player", "p1")
                        .WithMany()
                        .HasForeignKey("p1PlayerId");

                    b.HasOne("RPS_Game.Models.Player", "p2")
                        .WithMany()
                        .HasForeignKey("p2PlayerId");
                });

            modelBuilder.Entity("RPS_Game.Models.Round", b =>
                {
                    b.HasOne("RPS_Game.Models.Game", null)
                        .WithMany("Rounds")
                        .HasForeignKey("GameId");

                    b.HasOne("RPS_Game.Models.Player", "Winner")
                        .WithMany()
                        .HasForeignKey("WinnerPlayerId");
                });
#pragma warning restore 612, 618
        }
    }
}