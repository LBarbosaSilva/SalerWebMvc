﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SalerWebMVC.Data;

namespace SalerWebMVC.Migrations
{
    [DbContext(typeof(SalerWebMVCContext))]
    [Migration("20211014161553_OtherEntities")]
    partial class OtherEntities
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("SalerWebMVC.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Department");
                });

            modelBuilder.Entity("SalerWebMVC.Models.SalesRecord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Amount");

                    b.Property<DateTime>("Date");

                    b.Property<int?>("SallerId");

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.HasIndex("SallerId");

                    b.ToTable("SalesRecord");
                });

            modelBuilder.Entity("SalerWebMVC.Models.Saller", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("BaseSalary");

                    b.Property<DateTime>("BirthDate");

                    b.Property<int?>("DepartmentId");

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Saller");
                });

            modelBuilder.Entity("SalerWebMVC.Models.SalesRecord", b =>
                {
                    b.HasOne("SalerWebMVC.Models.Saller", "Saller")
                        .WithMany("Sales")
                        .HasForeignKey("SallerId");
                });

            modelBuilder.Entity("SalerWebMVC.Models.Saller", b =>
                {
                    b.HasOne("SalerWebMVC.Models.Department", "Department")
                        .WithMany("Sellers")
                        .HasForeignKey("DepartmentId");
                });
#pragma warning restore 612, 618
        }
    }
}