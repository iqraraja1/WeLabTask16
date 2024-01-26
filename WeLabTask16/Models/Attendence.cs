using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeLabTask16.Models
{
	public class Attendence
	{
        public int rollno { get; set; }
        public string subject { get; set; }
		public char present { get; set; }
		public DateTime date { get; set; }

		
	}
}