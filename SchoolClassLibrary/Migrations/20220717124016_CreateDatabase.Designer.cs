﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SchoolClassLibrary.DataLayer;

#nullable disable

namespace SchoolClassLibrary.Migrations
{
    [DbContext(typeof(SchoolContext))]
    [Migration("20220717124016_CreateDatabase")]
    partial class CreateDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SchoolClassLibrary.DataLayer.Entities.Class", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int?>("GradeID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("GradeID");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("SchoolClassLibrary.DataLayer.Entities.Course", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Month")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SchoolID")
                        .HasColumnType("int");

                    b.Property<string>("Year")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("SchoolID");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("SchoolClassLibrary.DataLayer.Entities.Grade", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SchoolID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("SchoolID");

                    b.ToTable("Grades");
                });

            modelBuilder.Entity("SchoolClassLibrary.DataLayer.Entities.Lesson", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("GradeID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfUnits")
                        .HasColumnType("int");

                    b.Property<int?>("TeacherID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("GradeID");

                    b.HasIndex("TeacherID");

                    b.ToTable("Lessons");
                });

            modelBuilder.Entity("SchoolClassLibrary.DataLayer.Entities.Mark", b =>
                {
                    b.Property<int>("StudentID")
                        .HasColumnType("int");

                    b.Property<int>("LessonID")
                        .HasColumnType("int");

                    b.Property<int>("CourseID")
                        .HasColumnType("int");

                    b.Property<double?>("Value")
                        .HasColumnType("float");

                    b.HasKey("StudentID", "LessonID", "CourseID");

                    b.HasIndex("CourseID");

                    b.HasIndex("LessonID");

                    b.ToTable("Marks");
                });

            modelBuilder.Entity("SchoolClassLibrary.DataLayer.Entities.School", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Area")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contact")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Province")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Section")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Schools");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Area = "Test",
                            City = "کرج",
                            Contact = "123456789",
                            Name = "Test",
                            Province = "البرز",
                            Section = "Test"
                        });
                });

            modelBuilder.Entity("SchoolClassLibrary.DataLayer.Entities.Staff", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Contact")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SchoolID")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("SchoolID");

                    b.ToTable("Staffs");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Contact = "123456789",
                            Firstname = "Admin",
                            Lastname = "Admin",
                            Password = "1234",
                            Role = "Admin",
                            SchoolID = 1,
                            Username = "admin"
                        });
                });

            modelBuilder.Entity("SchoolClassLibrary.DataLayer.Entities.Student", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("ClassID")
                        .HasColumnType("int");

                    b.Property<string>("Fathername")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NationalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoAddress")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("ClassID");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("SchoolClassLibrary.DataLayer.Entities.Teacher", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SchoolID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("SchoolID");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("SchoolClassLibrary.DataLayer.Entities.Class", b =>
                {
                    b.HasOne("SchoolClassLibrary.DataLayer.Entities.Grade", "Grade")
                        .WithMany("Classes")
                        .HasForeignKey("GradeID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .HasConstraintName("FK_Class_Grade");

                    b.Navigation("Grade");
                });

            modelBuilder.Entity("SchoolClassLibrary.DataLayer.Entities.Course", b =>
                {
                    b.HasOne("SchoolClassLibrary.DataLayer.Entities.School", "School")
                        .WithMany("Courses")
                        .HasForeignKey("SchoolID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_Course_School");

                    b.Navigation("School");
                });

            modelBuilder.Entity("SchoolClassLibrary.DataLayer.Entities.Grade", b =>
                {
                    b.HasOne("SchoolClassLibrary.DataLayer.Entities.School", "School")
                        .WithMany("Grades")
                        .HasForeignKey("SchoolID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_Grade_School");

                    b.Navigation("School");
                });

            modelBuilder.Entity("SchoolClassLibrary.DataLayer.Entities.Lesson", b =>
                {
                    b.HasOne("SchoolClassLibrary.DataLayer.Entities.Grade", "Grade")
                        .WithMany("Lessons")
                        .HasForeignKey("GradeID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_Lesson_Grade");

                    b.HasOne("SchoolClassLibrary.DataLayer.Entities.Teacher", "Teacher")
                        .WithMany("Lessons")
                        .HasForeignKey("TeacherID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .HasConstraintName("FK_Lesson_Teacher");

                    b.Navigation("Grade");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("SchoolClassLibrary.DataLayer.Entities.Mark", b =>
                {
                    b.HasOne("SchoolClassLibrary.DataLayer.Entities.Course", "Course")
                        .WithMany("Marks")
                        .HasForeignKey("CourseID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_Mark_Course");

                    b.HasOne("SchoolClassLibrary.DataLayer.Entities.Lesson", "Lesson")
                        .WithMany("Marks")
                        .HasForeignKey("LessonID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_Mark_Lesson");

                    b.HasOne("SchoolClassLibrary.DataLayer.Entities.Student", "Student")
                        .WithMany("Marks")
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_Mark_Student");

                    b.Navigation("Course");

                    b.Navigation("Lesson");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("SchoolClassLibrary.DataLayer.Entities.Staff", b =>
                {
                    b.HasOne("SchoolClassLibrary.DataLayer.Entities.School", "School")
                        .WithMany("Staffs")
                        .HasForeignKey("SchoolID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_Staff_School");

                    b.Navigation("School");
                });

            modelBuilder.Entity("SchoolClassLibrary.DataLayer.Entities.Student", b =>
                {
                    b.HasOne("SchoolClassLibrary.DataLayer.Entities.Class", "Class")
                        .WithMany("Students")
                        .HasForeignKey("ClassID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_Student_Class");

                    b.Navigation("Class");
                });

            modelBuilder.Entity("SchoolClassLibrary.DataLayer.Entities.Teacher", b =>
                {
                    b.HasOne("SchoolClassLibrary.DataLayer.Entities.School", "School")
                        .WithMany("Teachers")
                        .HasForeignKey("SchoolID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_Teacher_School");

                    b.Navigation("School");
                });

            modelBuilder.Entity("SchoolClassLibrary.DataLayer.Entities.Class", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("SchoolClassLibrary.DataLayer.Entities.Course", b =>
                {
                    b.Navigation("Marks");
                });

            modelBuilder.Entity("SchoolClassLibrary.DataLayer.Entities.Grade", b =>
                {
                    b.Navigation("Classes");

                    b.Navigation("Lessons");
                });

            modelBuilder.Entity("SchoolClassLibrary.DataLayer.Entities.Lesson", b =>
                {
                    b.Navigation("Marks");
                });

            modelBuilder.Entity("SchoolClassLibrary.DataLayer.Entities.School", b =>
                {
                    b.Navigation("Courses");

                    b.Navigation("Grades");

                    b.Navigation("Staffs");

                    b.Navigation("Teachers");
                });

            modelBuilder.Entity("SchoolClassLibrary.DataLayer.Entities.Student", b =>
                {
                    b.Navigation("Marks");
                });

            modelBuilder.Entity("SchoolClassLibrary.DataLayer.Entities.Teacher", b =>
                {
                    b.Navigation("Lessons");
                });
#pragma warning restore 612, 618
        }
    }
}
