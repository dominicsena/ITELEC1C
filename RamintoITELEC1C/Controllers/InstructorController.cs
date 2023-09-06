using Microsoft.AspNetCore.Mvc;
using RamintoITELEC1C.Models;


namespace RamintoITELEC1C.Controllers
{
    public class InstructorController : Controller
    {
        public IActionResult Index()
        {
            List<Instructor> InstructorList = new List<Instructor>()
            {
                new Instructor()
                {
                    InstructorName = "Gabriel Montano", DateHired = DateTime.Now,
                    InstructorEmail = "gdmontano@ust.edu.ph", Rank = Rank.Instructor,
                    InstructorId = 100
                },
                
                new Instructor()
                {
                    InstructorName = "Gabriel Montano", DateHired = DateTime.Now,
                    InstructorEmail = "gdmontano@ust.edu.ph", Rank = Rank.Instructor,
                    InstructorId = 200
                },

                new Instructor()
                {
                    InstructorName = "Gabriel Montano", DateHired = DateTime.Now,
                    InstructorEmail = "gdmontano@ust.edu.ph", Rank = Rank.Instructor,
                    InstructorId = 300
                },
                

                };

            return View(InstructorList);
        }
    }
}
