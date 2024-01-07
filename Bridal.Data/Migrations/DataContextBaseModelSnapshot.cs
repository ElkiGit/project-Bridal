﻿// <auto-generated />
using System;
using Bridal.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Bridal.Data.Migrations
{
    [DbContext(typeof(DataContextBase))]
    partial class DataContextBaseModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Bridal.Core.Entities.BridalClass", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DateWedding")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("dressmakerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("dressmakerId");

                    b.ToTable("Bridal");
                });

            modelBuilder.Entity("Bridal.Core.Entities.Dressmaker", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("experience")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Dressmaker");
                });

            modelBuilder.Entity("Bridal.Core.Entities.QueueBridal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DateQueue")
                        .HasColumnType("datetime2");

                    b.Property<int>("bridalId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("bridalId");

                    b.ToTable("QueueBridal");
                });

            modelBuilder.Entity("Bridal.Core.Entities.BridalClass", b =>
                {
                    b.HasOne("Bridal.Core.Entities.Dressmaker", "dressmaker")
                        .WithMany()
                        .HasForeignKey("dressmakerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("dressmaker");
                });

            modelBuilder.Entity("Bridal.Core.Entities.QueueBridal", b =>
                {
                    b.HasOne("Bridal.Core.Entities.BridalClass", "bridal")
                        .WithMany()
                        .HasForeignKey("bridalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("bridal");
                });
#pragma warning restore 612, 618
        }
    }
}
