using Microsoft.AspNetCore.Mvc;
using RamintoITELEC1C.Models;

namespace RamintoITELEC1C.Controllers
{

    public class StudentController : Controller
    {
        public IActionResult Index()
        {


            {
                Student st = new Student();
                st.StudentId = 2021154552;
                st.StudentName = "Dominic Seña";
                st.DateEnrolled = DateTime.Parse("30/08/2023");
                st.Course = Course.BSIT;
                st.Email = "jabrieldominic.raminto.cics@ust.edu.ph";

                ViewBag.student = st;


                return View();
            }
        }
    }
}
