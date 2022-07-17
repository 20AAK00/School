using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolClassLibrary.Migrations
{
    public partial class CreateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Schools",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Area = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Section = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Province = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contact = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schools", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Month = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SchoolID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Course_School",
                        column: x => x.SchoolID,
                        principalTable: "Schools",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Grades",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SchoolID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grades", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Grade_School",
                        column: x => x.SchoolID,
                        principalTable: "Schools",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Staffs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Firstname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lastname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contact = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SchoolID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staffs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Staff_School",
                        column: x => x.SchoolID,
                        principalTable: "Schools",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Firstname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lastname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SchoolID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Teacher_School",
                        column: x => x.SchoolID,
                        principalTable: "Schools",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GradeID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Class_Grade",
                        column: x => x.GradeID,
                        principalTable: "Grades",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Lessons",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfUnits = table.Column<int>(type: "int", nullable: false),
                    GradeID = table.Column<int>(type: "int", nullable: false),
                    TeacherID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lessons", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Lesson_Grade",
                        column: x => x.GradeID,
                        principalTable: "Grades",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Lesson_Teacher",
                        column: x => x.TeacherID,
                        principalTable: "Teachers",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Firstname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lastname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fathername = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NationalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhotoAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClassID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Student_Class",
                        column: x => x.ClassID,
                        principalTable: "Classes",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Marks",
                columns: table => new
                {
                    StudentID = table.Column<int>(type: "int", nullable: false),
                    LessonID = table.Column<int>(type: "int", nullable: false),
                    CourseID = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marks", x => new { x.StudentID, x.LessonID, x.CourseID });
                    table.ForeignKey(
                        name: "FK_Mark_Course",
                        column: x => x.CourseID,
                        principalTable: "Courses",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Mark_Lesson",
                        column: x => x.LessonID,
                        principalTable: "Lessons",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Mark_Student",
                        column: x => x.StudentID,
                        principalTable: "Students",
                        principalColumn: "ID");
                });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "ID", "Area", "City", "Contact", "Name", "Province", "Section" },
                values: new object[] { 1, "Test", "کرج", "123456789", "Test", "البرز", "Test" });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "ID", "Contact", "Firstname", "Lastname", "Password", "Role", "SchoolID", "Username" },
                values: new object[] { 1, "123456789", "Admin", "Admin", "1234", "Admin", 1, "admin" });

            migrationBuilder.CreateIndex(
                name: "IX_Classes_GradeID",
                table: "Classes",
                column: "GradeID");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_SchoolID",
                table: "Courses",
                column: "SchoolID");

            migrationBuilder.CreateIndex(
                name: "IX_Grades_SchoolID",
                table: "Grades",
                column: "SchoolID");

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_GradeID",
                table: "Lessons",
                column: "GradeID");

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_TeacherID",
                table: "Lessons",
                column: "TeacherID");

            migrationBuilder.CreateIndex(
                name: "IX_Marks_CourseID",
                table: "Marks",
                column: "CourseID");

            migrationBuilder.CreateIndex(
                name: "IX_Marks_LessonID",
                table: "Marks",
                column: "LessonID");

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_SchoolID",
                table: "Staffs",
                column: "SchoolID");

            migrationBuilder.CreateIndex(
                name: "IX_Students_ClassID",
                table: "Students",
                column: "ClassID");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_SchoolID",
                table: "Teachers",
                column: "SchoolID");

            migrationBuilder.Sql(
                @"
CREATE PROCEDURE RanksAveragesInGrade
	@gradeid INT,
	@courseid INT
AS
	DECLARE @StudentsOfGrade TABLE (ID INT);

	INSERT INTO @StudentsOfGrade
		SELECT Students.ID
		FROM Students
		WHERE
			Students.ClassID IN 
				(
				SELECT Classes.ID
				FROM Classes
				WHERE Classes.GradeID = @gradeid
				);

	SELECT Marks.StudentID, AVG(Marks.Value) AS 'Average', RANK() OVER(ORDER BY AVG(Marks.Value) DESC) AS 'Rank'
	FROM Marks
	WHERE 
		Marks.CourseID = @courseid AND
		StudentID IN
			(
			SELECT *
			FROM @StudentsOfGrade
			)
	GROUP BY Marks.StudentID
GO

CREATE PROCEDURE RanksAveragesInClass
	@classid INT,
	@courseid INT
AS
	SELECT Marks.StudentID, AVG(Marks.Value) AS 'Average', RANK() OVER(ORDER BY AVG(Marks.Value) DESC) AS 'Rank'
	FROM Marks
	WHERE 
		Marks.CourseID = @courseid AND
		StudentID IN
			(
			SELECT Students.ID
			FROM Students
			WHERE Students.ClassID = @classid
			)
	GROUP BY Marks.StudentID
GO

CREATE PROCEDURE RanksInLesson
	@classid INT,
	@courseid INT
AS
	SELECT Marks.StudentID, Marks.LessonID, dbo.LessonRanks(Marks.StudentID, @courseid, Marks.LessonID) AS 'Rank'
	FROM Marks
	WHERE
		CourseID = @courseid AND
		StudentID IN
			(
			SELECT ID
			FROM Students
			WHERE Students.ClassID = @classid
			)
GO

CREATE FUNCTION LessonRanks
(
	@studentid AS INT,
	@courseid AS INT,
	@lessonid AS INT
)
RETURNS INT
AS
BEGIN
	DECLARE @rank INT;
	SELECT @rank = Sorted.Rank
	FROM 
	(SELECT StudentID, RANK() OVER(ORDER BY Marks.Value DESC) AS 'Rank'
	FROM Marks
	WHERE CourseID = @courseid AND LessonID = @lessonid) AS Sorted
	WHERE Sorted.StudentID = @studentid;
	RETURN @rank;
END;
GO

CREATE FUNCTION GetStaff(@schoolid AS INT, @role AS NVARCHAR(MAX))
RETURNS NVARCHAR(MAX)
AS
BEGIN
	DECLARE @someone AS NVARCHAR(MAX)

	SELECT @someone = Firstname + ' ' + Lastname
	FROM Staffs
	WHERE SchoolID = @schoolid AND Role = @role

	RETURN @someone;
END
GO

CREATE PROCEDURE GetSchoolInfo
	@schoolid AS INT
AS
	SELECT Schools.*, dbo.GetStaff(@schoolid, N'مدیر'), dbo.GetStaff(@schoolid, N'معاون اجرایی')
	FROM Schools
	WHERE Schools.ID = @schoolid;
GO
");

            migrationBuilder.Sql(
                @"
CREATE TRIGGER DeleteSchool
	ON Schools
	INSTEAD OF DELETE
AS
	DELETE FROM Staffs WHERE SchoolID IN (SELECT ID FROM DELETED)
	DELETE FROM Courses WHERE SchoolID IN (SELECT ID FROM DELETED)
	DELETE FROM Teachers WHERE SchoolID IN (SELECT ID FROM DELETED)
	DELETE FROM Grades WHERE SchoolID IN (SELECT ID FROM DELETED)
	DELETE FROM Schools WHERE ID IN (SELECT ID FROM DELETED)
GO

CREATE TRIGGER DeleteCourse
	ON Courses
	INSTEAD OF DELETE
AS
	DELETE FROM Marks WHERE CourseID IN (SELECT ID FROM DELETED)
	DELETE FROM Courses WHERE ID IN (SELECT ID FROM DELETED)
GO

CREATE TRIGGER DeleteTeacher
	ON Teachers
	INSTEAD OF DELETE
AS
	DELETE FROM Lessons WHERE TeacherID IN (SELECT ID FROM DELETED)
	DELETE FROM Teachers WHERE ID IN (SELECT ID FROM DELETED)
GO

CREATE TRIGGER DeleteGrade
	ON Grades
	INSTEAD OF DELETE
AS
	DELETE FROM Classes WHERE GradeID IN (SELECT ID FROM DELETED)
	DELETE FROM Lessons WHERE GradeID IN (SELECT ID FROM DELETED)
	DELETE FROM Grades WHERE ID IN (SELECT ID FROM DELETED)
GO

CREATE TRIGGER DeleteClass
	ON Classes
	INSTEAD OF DELETE
AS
	DELETE FROM Students WHERE ClassID IN (SELECT ID FROM DELETED)
	DELETE FROM Classes WHERE ID IN (SELECT ID FROM DELETED)
GO

CREATE TRIGGER DeleteStudent
	ON Students
	INSTEAD OF DELETE
AS
	DELETE FROM Marks WHERE StudentID IN (SELECT ID FROM DELETED)
	DELETE FROM Students WHERE ID IN (SELECT ID FROM DELETED)
GO

CREATE TRIGGER DeleteLesson
	ON Lessons
	INSTEAD OF DELETE
AS
	DELETE FROM Marks WHERE LessonID IN (SELECT ID FROM DELETED)
	DELETE FROM Lessons WHERE ID IN (SELECT ID FROM DELETED)
GO
");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Marks");

            migrationBuilder.DropTable(
                name: "Staffs");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Lessons");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "Grades");

            migrationBuilder.DropTable(
                name: "Schools");
        }
    }
}
