﻿// <auto-generated />
using DiabetesControl.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DiabetesControl.Data.Migrations
{
    [DbContext(typeof(MasterContext))]
    partial class MasterContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("DiabetesControl.Data.Models.Food", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("NutritionalMeasureId")
                        .HasColumnType("int");

                    b.Property<int>("NutritiveGroup")
                        .HasColumnType("int");

                    b.Property<int>("NutritiveValueId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NutritionalMeasureId")
                        .IsUnique();

                    b.HasIndex("NutritiveValueId")
                        .IsUnique();

                    b.ToTable("Foods");
                });

            modelBuilder.Entity("DiabetesControl.Data.Models.NutritionalMeasure", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("MeasureAverage")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Quantity")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("NutritionalMeasures");
                });

            modelBuilder.Entity("DiabetesControl.Data.Models.NutritiveValue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CarbohdrateValue")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("FatValue")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ProteinValue")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("NutritiveValue");
                });

            modelBuilder.Entity("DiabetesControl.Data.Models.Food", b =>
                {
                    b.HasOne("DiabetesControl.Data.Models.NutritionalMeasure", "NutritionalMeasure")
                        .WithOne("Foods")
                        .HasForeignKey("DiabetesControl.Data.Models.Food", "NutritionalMeasureId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DiabetesControl.Data.Models.NutritiveValue", "NutritiveValue")
                        .WithOne("Foods")
                        .HasForeignKey("DiabetesControl.Data.Models.Food", "NutritiveValueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NutritionalMeasure");

                    b.Navigation("NutritiveValue");
                });

            modelBuilder.Entity("DiabetesControl.Data.Models.NutritionalMeasure", b =>
                {
                    b.Navigation("Foods");
                });

            modelBuilder.Entity("DiabetesControl.Data.Models.NutritiveValue", b =>
                {
                    b.Navigation("Foods");
                });
#pragma warning restore 612, 618
        }
    }
}
