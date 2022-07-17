using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolClassLibrary.DataLayer.Entities
{
	public class Staff : ISource
	{
		[Key]
		public int ID { get; set; }
		[Required]
		public string Firstname { get; set; }
		[Required]
		public string Lastname { get; set; }
		[NotMapped]
		public string Name { get; set; }
		[Required]
		public string Username { get; set; }
		[Required]
		public string Password { get; set; }
		[Required]
		public string Role { get; set; }
		[Required]
		public string Contact { get; set; }

		public int SchoolID { get; set; }
		public virtual School School { get; set; }
	}
}
