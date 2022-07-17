using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolClassLibrary.DataLayer.Entities
{
	public class Lesson : ISource
	{
		public int ID { get; set; }
		[Required]
		public string Name { get; set; }
		[Required]
		public int NumberOfUnits { get; set; }

		// Lesson - Grade
		public int GradeID { get; set; }
		public Grade Grade { get; set; }
		// Lesson Teacher
		public int? TeacherID { get; set; }
		public Teacher Teacher { get; set; }

		// Lesson - Mark
		public ICollection<Mark> Marks { get; set; }
	}
}
