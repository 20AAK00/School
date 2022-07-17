using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SchoolClassLibrary.DataLayer.Entities
{
	public class Class : ISource
	{
		// Properties
		public int ID { get; set; }
		[Required]
		public string Name { get; set; }

		// Class - Grade
		public int? GradeID { get; set; }
		public virtual Grade Grade { get; set; }

		// Class - Student
		public ICollection<Student> Students { get; set; }
	}
}
