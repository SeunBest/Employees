﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Property_Sets;

namespace Property_Sets.Migrations
{
    [DbContext(typeof(PersonContext))]
    [Migration("20200906221419_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Property_Sets.Department", b =>
                {
                    b.Property<int>("departmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("departmentName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("departmentId");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("Property_Sets.Employee", b =>
                {
                    b.Property<int>("employeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("departmentId")
                        .HasColumnType("int");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("firstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("hireDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("lastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("salary")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("employeeId");

                    b.HasIndex("departmentId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Property_Sets.Employee", b =>
                {
                    b.HasOne("Property_Sets.Department", "department")
                        .WithMany()
                        .HasForeignKey("departmentId");
                });
#pragma warning restore 612, 618
        }
    }
}
