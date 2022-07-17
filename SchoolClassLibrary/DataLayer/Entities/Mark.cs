using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolClassLibrary.DataLayer.Entities
{
	public class Mark
	{
		public double? Value { get; set; }

		[Key]
		public int StudentID { get; set; }
		public virtual Student Student { get; set; }

		[Key]
		public int LessonID { get; set; }
		public virtual Lesson Lesson { get; set; }

		[Key]
		public int CourseID { get; set; }
		public virtual Course Course { get; set; }
	}
}
