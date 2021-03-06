﻿// <auto-generated />
using System;
using HomeWork28.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HomeWork28.Migrations
{
    [DbContext(typeof(DCon))]
    partial class DConModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4");

            modelBuilder.Entity("HomeWork28.Model.Frazi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Author")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Frazes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Hurshed",
                            Date = new DateTime(2020, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Text = "Vsyo Menyaetsya"
                        },
                        new
                        {
                            Id = 2,
                            Author = "Payrav",
                            Date = new DateTime(2020, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Text = "Ploxo sojelet o tom chto ne tak jil"
                        },
                        new
                        {
                            Id = 3,
                            Author = "Firdavs",
                            Date = new DateTime(2020, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Text = "Vigral grin kartu"
                        },
                        new
                        {
                            Id = 4,
                            Author = "Shahzod",
                            Date = new DateTime(2020, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Text = "Vzlom wifi"
                        },
                        new
                        {
                            Id = 5,
                            Author = "Karim",
                            Date = new DateTime(2020, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Text = "Jivi dolgo"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
