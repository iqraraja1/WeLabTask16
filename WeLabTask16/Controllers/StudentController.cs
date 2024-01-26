using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WeLabTask16.Models;

namespace WeLabTask16.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        DBManager obj=new DBManager();
        [HttpGet]
        public ActionResult Student()
        {
            return View();
        }
        [HttpPost]
		public ActionResult SaveStudent(Student s)
		{
            string q = $"insert into Student values ('{s.Name}','{s.Class}','{s.Subject}')";
            obj.IUD(q);


			return View("Student",s);
		}
        [HttpGet]
		public ActionResult SubjectData()
		{
            Student s;
			string q = "select * from Student";
            SqlDataReader sdr = obj.fetch(q);
            List<Student> students = new List<Student>();   
            while (sdr.Read()) {
                 s = new Student();
                s.rollno = int.Parse(sdr["Rollno"].ToString());
                s.Name = sdr["Name"].ToString();
                s.Class = sdr["Clas"].ToString();
                s.Subject = sdr["Subject"].ToString() ;
                students.Add(s);    
              
            
            }

			return View("SubjectData",students);
		}
        [HttpGet]
        public ActionResult partial() {

            return View();
        }
		List<Student> students = new List<Student>();
		[HttpGet]
		public ActionResult Attendence(string subject)
		{
			Student s;
			string q = "select * from Student";
			SqlDataReader sdr = obj.fetch(q);
		
			while (sdr.Read())
			{
				s = new Student();
                s.rollno = int.Parse(sdr["Rollno"].ToString());
				s.Name = sdr["Name"].ToString();
				s.Class = sdr["Clas"].ToString();
				s.Subject = sdr["Subject"].ToString();
				students.Add(s);
			}
            var lst=students.Where(s1=>s1.Subject == subject).ToList();   

			return View(lst);
		}
        [HttpPost]
        public ActionResult SaveAttendence(int rollno) {

            //string qury = $"select * from Student where rollno='{rollno}'";
            //SqlDataReader sdr=obj.fetch(qury);

			//string q = $"insert into Attendence values ('{int.Parse(sdr["Rollno"].ToString())}','{sdr["Subject"].ToString()}','{}','{DateTime.Now}')";

			return View();
        
        }

	}
}