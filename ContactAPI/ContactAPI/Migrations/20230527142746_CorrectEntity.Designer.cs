﻿// <auto-generated />
using System;
using ContactAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ContactAPI.Migrations
{
    [DbContext(typeof(SqlContext))]
    [Migration("20230527142746_CorrectEntity")]
    partial class CorrectEntity
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.0-preview.4.23259.3");

            modelBuilder.Entity("ContactAPI.Model.ContactModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Contact")
                        .HasMaxLength(9)
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatAt")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Deleted")
                        .HasColumnType("INTEGER");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT")
                        .HasAnnotation("MinLength", 6)
                        .HasAnnotation("RegularExpression", "^[^@\\s]+@[^@\\s]+\\.[^@\\s]+$");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasAnnotation("MinLength", 5);

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Contato");
                });
#pragma warning restore 612, 618
        }
    }
}