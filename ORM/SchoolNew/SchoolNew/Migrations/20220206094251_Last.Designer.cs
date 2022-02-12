﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SchoolNew;

namespace SchoolNew.Migrations
{
    [DbContext(typeof(SchoolDbContext))]
    [Migration("20220206094251_Last")]
    partial class Last
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("SchoolNew.Models.City", b =>
                {
                    b.Property<int>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("CityId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("SchoolNew.Models.School", b =>
                {
                    b.Property<int>("SchoolPK")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("SchoolPK");

                    b.ToTable("NewSchool");

                    b.HasData(
                        new
                        {
                            SchoolPK = 1,
                            Name = "Vasil Levski"
                        },
                        new
                        {
                            SchoolPK = 2,
                            Name = "Vasil Levski"
                        },
                        new
                        {
                            SchoolPK = 3,
                            Name = "Vasil Levski"
                        },
                        new
                        {
                            SchoolPK = 4,
                            Name = "Vasil Levski"
                        });
                });

            modelBuilder.Entity("SchoolNew.Models.Student", b =>
                {
                    b.Property<int>("TestPK")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<int?>("SchoolPK")
                        .HasColumnType("int");

                    b.Property<int?>("city_id")
                        .HasColumnType("int");

                    b.HasKey("TestPK");

                    b.HasIndex("SchoolPK");

                    b.HasIndex("city_id");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            TestPK = 1,
                            Age = 12,
                            Name = "Koko",
                            SchoolPK = 2
                        });
                });

            modelBuilder.Entity("SchoolNew.Models.StudentTeacher", b =>
                {
                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.HasKey("StudentId", "TeacherId");

                    b.HasIndex("TeacherId");

                    b.ToTable("StudentsTeachers");
                });

            modelBuilder.Entity("SchoolNew.Models.Teacher", b =>
                {
                    b.Property<int>("TeacherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Discipline")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("TeacherId");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("SchoolNew.Models.Student", b =>
                {
                    b.HasOne("SchoolNew.Models.School", "School")
                        .WithMany("Students")
                        .HasForeignKey("SchoolPK");

                    b.HasOne("SchoolNew.Models.City", "City")
                        .WithMany()
                        .HasForeignKey("city_id");
                });

            modelBuilder.Entity("SchoolNew.Models.StudentTeacher", b =>
                {
                    b.HasOne("SchoolNew.Models.Student", "Student")
                        .WithMany("StudentTeacher")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SchoolNew.Models.Teacher", "Teacher")
                        .WithMany("StudentTeacher")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}