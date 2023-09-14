using Microsoft.AspNetCore.Mvc;
using RamintoITELEC1C.Models;


namespace RamintoITELEC1C.Controllers
{
    public class InstructorController : Controller
    {
       
            List<Instructor> InstructorList = new List<Instructor>()
            {
                new Instructor()
                {
                    InstructorId = 1, InstructorFirstName = "Gabriel", InstructorLastName = "Montano",
                    InstructorEmail = "gdmontano@ust.edu.ph", IsTenured = true, HiringDate = DateTime.Now,
                    Rank = Rank.Instructor
                },
                
                new Instructor()
                {
                     InstructorId = 2, InstructorFirstName = "Gabriel", InstructorLastName = "Montano",
                    InstructorEmail = "gdmontano@ust.edu.ph", IsTenured = true, HiringDate = DateTime.Now,
                    Rank = Rank.Instructor
                },

                new Instructor()
                {
                     InstructorId = 3, InstructorFirstName = "Gabriel", InstructorLastName = "Montano",
                    InstructorEmail = "gdmontano@ust.edu.ph", IsTenured = true, HiringDate = DateTime.Now,
                    Rank = Rank.Instructor
                }
                

                };
        public IActionResult Index()
        {
            return View(InstructorList);
        }
    


    

        public IActionResult ShowDetail(int id)
        {
        Instructor? instructor = InstructorList.FirstOrDefault(st => st.InstructorId == id);
        if (instructor != null)
                return View(instructor);

            return NotFound();

        }

    }
}
