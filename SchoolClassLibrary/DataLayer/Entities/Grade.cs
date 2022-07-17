using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SchoolClassLibrary.DataLayer.Entities
{
	public class Grade : ISource
	{
		public int ID { get; set; }
		[Required]
		public string Name { get; set; }

		public int SchoolID { get; set; }
		public virtual School School { get; set; }

		public ICollection<Class> Classes { get; set; }
		public ICollection<Lesson> Lessons { get; set; }
	}
}
