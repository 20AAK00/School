using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClassLibrary.DataLayer
{
	public interface ISource
	{
		public int ID { get; set; }
		public string Name { get; }
	}
}
