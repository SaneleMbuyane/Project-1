using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace SaneleStudyGroup.Controllers
{
    public class StudentsController : Controller
    {
        // GET: Students
        public ActionResult Index()
        {
            List<Students> students = new List<Students>();

            students.Add(new Students { StudentNumber = 22614835, Name= "Sanele", Surname= "Mbuyane", EmailAddress="u22614835@tuks.co.za", myLink="LINK"});
            students.Add(new Students { StudentNumber = 21616672, Name = "Comfort", Surname = "Magagula", EmailAddress = "u21616672@tuks.co.za", myLink = "LINK" });
            students.Add(new Students { StudentNumber = 22526884, Name = "Pearl", Surname = "Khoza", EmailAddress = "u22526884@tuks.co.za", myLink = "LINK" });
            students.Add(new Students { StudentNumber = 23756973, Name = "Lindo", Surname = "Mchunu", EmailAddress = "u23756973@tuks.co.za", myLink = "LINK" });
            students.Add(new Students { StudentNumber = 22435617, Name = "Sane", Surname = "Ngwenya", EmailAddress = "u22435617@tuks.co.za", myLink = "LINK" });

            return View(students);
        }
    }
}