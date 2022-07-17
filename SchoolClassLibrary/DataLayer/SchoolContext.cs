using Microsoft.EntityFrameworkCore;
using SchoolClassLibrary.DataLayer.Entities;

namespace SchoolClassLibrary.DataLayer
{
	public class SchoolContext : DbContext
	{
		// Constructors
		public SchoolContext()
		{

		}

		// Properties
		// Tables
		public virtual DbSet<School> Schools { get; set; }
		public virtual DbSet<Staff> Staffs { get; set; }
		public virtual DbSet<Course> Courses { get; set; }
		public virtual DbSet<Grade> Grades { get; set; }
		public virtual DbSet<Class> Classes { get; set; }
		public virtual DbSet<Student> Students { get; set; }
		public virtual DbSet<Lesson> Lessons { get; set; }
		public virtual DbSet<Teacher> Teachers { get; set; }
		public virtual DbSet<Mark> Marks { get; set; }

		// Methods
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS2012;Database=School;Trusted_Connection=True;");
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			// School
			// School Seed Data
			modelBuilder.Entity<School>().HasData(
				new School()
				{
					ID = 1,
					Name = "Test",
					Area = "Test",
					Section = "Test",
					City = "کرج",
					Province = "البرز",
					Contact = "123456789"
				});

			// Staff
			// Staff Seed Data
			modelBuilder.Entity<Staff>().HasData(
				new Staff()
				{
					ID = 1,
					Firstname = "Admin",
					Lastname = "Admin",
					Username = "admin",
					Password = "1234",
					Role = "Admin",
					Contact = "123456789",
					SchoolID = 1
				});

			// Staff - School
			modelBuilder.Entity<Staff>()
				.HasOne(staff => staff.School)
				.WithMany(school => school.Staffs)
				.HasForeignKey(staff => staff.SchoolID)
				.OnDelete(DeleteBehavior.NoAction)
				.HasConstraintName("FK_Staff_School");

			// Course
			// Course - School
			modelBuilder.Entity<Course>()
				.HasOne(course => course.School)
				.WithMany(school => school.Courses)
				.HasForeignKey(course => course.SchoolID)
				.OnDelete(DeleteBehavior.NoAction)
				.HasConstraintName("FK_Course_School");

			// Teacher
			// Teacher - School
			modelBuilder.Entity<Teacher>()
				.HasOne(teacher => teacher.School)
				.WithMany(school => school.Teachers)
				.HasForeignKey(teacher => teacher.SchoolID)
				.OnDelete(DeleteBehavior.NoAction)
				.HasConstraintName("FK_Teacher_School");

			// Grade
			// Grade - School
			modelBuilder.Entity<Grade>()
				.HasOne(grade => grade.School)
				.WithMany(school => school.Grades)
				.HasForeignKey(grade => grade.SchoolID)
				.OnDelete(DeleteBehavior.NoAction)
				.HasConstraintName("FK_Grade_School");

			// Class
			// Class - Grade
			modelBuilder.Entity<Class>()
				.HasOne(tclass => tclass.Grade)
				.WithMany(grade => grade.Classes)
				.HasForeignKey(tclass => tclass.GradeID)
				.OnDelete(DeleteBehavior.NoAction)
				.HasConstraintName("FK_Class_Grade");

			// Student
			// Student - Class
			modelBuilder.Entity<Student>()
				.HasOne(student => student.Class)
				.WithMany(tclass => tclass.Students)
				.HasForeignKey(student => student.ClassID)
				.OnDelete(DeleteBehavior.NoAction)
				.HasConstraintName("FK_Student_Class");

			// Lesson
			// Lesson - Grade
			modelBuilder.Entity<Lesson>()
				.HasOne(lesson => lesson.Grade)
				.WithMany(grade => grade.Lessons)
				.HasForeignKey(lesson => lesson.GradeID)
				.OnDelete(DeleteBehavior.NoAction)
				.HasConstraintName("FK_Lesson_Grade");

			// Lesson - Teacher
			modelBuilder.Entity<Lesson>()
				.HasOne(lesson => lesson.Teacher)
				.WithMany(teacher => teacher.Lessons)
				.HasForeignKey(lesson => lesson.TeacherID)
				.OnDelete(DeleteBehavior.NoAction)
				.HasConstraintName("FK_Lesson_Teacher");

			// Mark
			// Primary Key
			modelBuilder.Entity<Mark>().HasKey("StudentID", "LessonID", "CourseID");

			// Mark - Student
			modelBuilder.Entity<Mark>()
				.HasOne(mark => mark.Student)
				.WithMany(student => student.Marks)
				.HasForeignKey(mark => mark.StudentID)
				.OnDelete(DeleteBehavior.NoAction)
				.HasConstraintName("FK_Mark_Student");

			// Mark - Lesson
			modelBuilder.Entity<Mark>()
				.HasOne(mark => mark.Lesson)
				.WithMany(lesson => lesson.Marks)
				.HasForeignKey(mark => mark.LessonID)
				.OnDelete(DeleteBehavior.NoAction)
				.HasConstraintName("FK_Mark_Lesson");

			// Mark - Course
			modelBuilder.Entity<Mark>()
				.HasOne(mark => mark.Course)
				.WithMany(course => course.Marks)
				.HasForeignKey(mark => mark.CourseID)
				.OnDelete(DeleteBehavior.NoAction)
				.HasConstraintName("FK_Mark_Course");
		}
	}
}
