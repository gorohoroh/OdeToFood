﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OdeToFood.Data;

#nullable disable

namespace OdeToFood.Migrations
{
    [DbContext(typeof(OdeToFoodDbContext))]
    [Migration("20240414194341_SeedInitialRestaurants")]
    partial class SeedInitialRestaurants
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.1");

            modelBuilder.Entity("OdeToFood.Models.Restaurant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Cuisine")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Restaurants");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Cuisine = 1,
                            Name = "The Italian Bistro"
                        },
                        new
                        {
                            Id = 2,
                            Cuisine = 2,
                            Name = "French Delight"
                        },
                        new
                        {
                            Id = 3,
                            Cuisine = 3,
                            Name = "Berlin's Best"
                        },
                        new
                        {
                            Id = 4,
                            Cuisine = 1,
                            Name = "Mama Mia's"
                        },
                        new
                        {
                            Id = 5,
                            Cuisine = 2,
                            Name = "The French Bakery"
                        },
                        new
                        {
                            Id = 6,
                            Cuisine = 3,
                            Name = "German Goodness"
                        },
                        new
                        {
                            Id = 7,
                            Cuisine = 1,
                            Name = "Pasta Paradise"
                        },
                        new
                        {
                            Id = 8,
                            Cuisine = 2,
                            Name = "Parisian Pleasures"
                        },
                        new
                        {
                            Id = 9,
                            Cuisine = 3,
                            Name = "Frankfurt Flavors"
                        },
                        new
                        {
                            Id = 10,
                            Cuisine = 1,
                            Name = "Venetian Vittles"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
