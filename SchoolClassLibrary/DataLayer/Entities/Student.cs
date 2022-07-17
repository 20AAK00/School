using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolClassLibrary.DataLayer.Entities
{
	public class Student : ISource
	{
		public int ID { get; set; }
		[Required]
		public string Firstname { get; set; }
		[Required]
		public string Lastname { get; set; }
		public string Fathername { get; set; }
		[NotMapped]
		public string Name { get => Firstname + " " + Lastname; }
		[Required]
		public string NationalCode { get; set; }
		public string PhotoAddress { get; set; }

		public int ClassID { get; set; }
		public virtual Class Class { get; set; }

		public ICollection<Mark> Marks { get; set; }
	}
}
