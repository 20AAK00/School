using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolClassLibrary.DataLayer.Entities
{
	public class Course : ISource
	{
		// Properties
		public int ID { get; set; }
		[Required]
		public string Month { get; set; }
		[Required]
		public string Year { get; set; }
		[NotMapped]
		public string Name { get => Month + " " + Year; }

		public int SchoolID { get; set; }
		public virtual School School { get; set; }

		public ICollection<Mark> Marks { get; set; }

	}
}
