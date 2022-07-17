using System.ComponentModel.DataAnnotations;

namespace SchoolClassLibrary.DataLayer.Entities
{
	public class School : ISource
	{
		[Key]
		public int ID { get; set; }
		[Required]
		public string Name { get; set; }
		[Required]
		public string Area { get; set; }
		[Required]
		public string Section { get; set; }
		[Required]
		public string City { get; set; }
		[Required]
		public string Province { get; set; }
		[Required]
		public string Contact { get; set; }

		public ICollection<Staff> Staffs { get; set; }
		public ICollection<Course> Courses { get; set; }
		public ICollection<Teacher> Teachers { get; set; }
		public ICollection<Grade> Grades { get; set; }


	}
}
