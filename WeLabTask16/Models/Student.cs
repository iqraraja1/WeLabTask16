using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeLabTask16.Models
{
	public class Student
	{
        public int rollno { get; set; }
        public string Name { get; set; }

		public string Class { get; set; }
		public string Subject { get; set; }
		public string isPresent { get; set; }
	}
}