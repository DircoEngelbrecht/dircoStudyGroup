using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace dircoStudyGroup.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult StudentDetails()
        {
            List<Models.StudentModel> student = new List<Models.StudentModel>();

            student.Add(new Models.StudentModel { StudentNumber = "u48372691", FirstName = "Chuck", LastName = "Bartowski", EmailAddress = "u48372691@tuks.co.za" });
            student.Add(new Models.StudentModel { StudentNumber = "u19284756", FirstName = "Sarah", LastName = "Walker", EmailAddress = "u19284756@tuks.co.za" });
            student.Add(new Models.StudentModel { StudentNumber = "u15029384", FirstName = "Olivia", LastName = "Clark", EmailAddress = "u15029384@tuks.co.za" });
            student.Add(new Models.StudentModel { StudentNumber = "u50381726", FirstName = "Benjamin", LastName = "Lee", EmailAddress = "u50381726@tuks.co.za" });
            student.Add(new Models.StudentModel { StudentNumber = "u38492075", FirstName = "Sophia", LastName = "Miller", EmailAddress = "u38492075@tuks.co.za" });
            
            return View(student);
        }
    }
}