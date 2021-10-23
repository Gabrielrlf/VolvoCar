﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VolvoCar.Infra;

namespace VolvoCar.Infra.Migrations
{
    [DbContext(typeof(VolvoCarDbContext))]
    partial class VolvoCarDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("VolvoCar.Domain.Model.Truck", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ModelName")
                        .HasMaxLength(2)
                        .HasColumnType("TEXT");

                    b.Property<int>("YearFabrication")
                        .HasColumnType("INTEGER");

                    b.Property<int>("YearModel")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Truck");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ModelName = "FH",
                            YearFabrication = 2021,
                            YearModel = 2022
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
