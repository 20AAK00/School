using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolClassLibrary.DataLayer.Entities
{
	public class Teacher : ISource
	{
		public int ID { get; set; }
		[Required]
		public string Firstname { get; set; }
		[Required]
		public string Lastname { get; set; }
		[NotMapped]
		public string Name { get => Firstname + " " + Lastname; }

		public int SchoolID { get; set; }
		public virtual School School { get; set; }

		public ICollection<Lesson> Lessons { get; set; }
	}
}
