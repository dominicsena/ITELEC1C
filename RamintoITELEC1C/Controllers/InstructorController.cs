using Microsoft.AspNetCore.Mvc;
using RamintoITELEC1C.Models;
using RamintoITELEC1C.Services;

namespace RamintoITELEC1C.Controllers
{
    public class InstructorController : Controller
    {
            private readonly InterfaceMyFakeDataService _dummyDatas;
        public InstructorController(InterfaceMyFakeDataService dummyDatas)
        {
            _dummyDatas = dummyDatas;
        }
       
        public IActionResult Index()
        {
            return View(_dummyDatas.InstructorList);
        }





        public IActionResult ShowDetail(int id)
        {
            Instructor? instructor = _dummyDatas.InstructorList.FirstOrDefault(st => st.InstructorId == id);
            if (instructor != null)
                return View(instructor);

            return NotFound();

        }

        [HttpGet]
        public IActionResult AddInstructor()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddInstructor(Instructor newinstructor)
        {
            if (!ModelState.IsValid)
                return View();
            _dummyDatas.InstructorList.Add(newinstructor);
            return RedirectToAction("Index");

        }



        [HttpGet]

        public IActionResult UpdateInstructor(int id)
        {

            Instructor? instructor = _dummyDatas.InstructorList.FirstOrDefault(st => st.InstructorId == id);

            if (instructor != null)
                return View(instructor);

            return NotFound();
        }


        [HttpPost]

        public IActionResult UpdateInstructor(Instructor instructorChanges)
        {

            Instructor? instructor = _dummyDatas.InstructorList.FirstOrDefault(it => it.InstructorId == instructorChanges.InstructorId);
            if (instructor != null)
            {

                instructor.InstructorFirstName = instructorChanges.InstructorFirstName;
                instructor.InstructorLastName = instructorChanges.InstructorLastName;
                instructor.Rank = instructorChanges.Rank;
                instructor.InstructorEmail = instructorChanges.InstructorEmail;
                instructor.HiringDate = instructorChanges.HiringDate;
                instructor.IsTenured = instructorChanges.IsTenured;

            }

            return RedirectToAction("Index");

        }

        [HttpGet]

        public IActionResult DeleteInstructor(int id)
        {
            Instructor? instructor = _dummyDatas.InstructorList.FirstOrDefault(st => st.InstructorId == id);
            if (instructor != null)
                return View(instructor);
            return NotFound();
        }


        [HttpPost]
        public IActionResult DeleteInstructor(Instructor removeInstructor)
        {
            Instructor? instructor = _dummyDatas.InstructorList.FirstOrDefault(st => st.InstructorId == removeInstructor.InstructorId);
            if (instructor != null)
                _dummyDatas.InstructorList.Remove(instructor);
            return RedirectToAction("Index");
        }


    }
}
