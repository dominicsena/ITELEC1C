using Microsoft.AspNetCore.Mvc;
using RamintoITELEC1C.Models;
using RamintoITELEC1C.Services;


namespace RamintoITELEC1C.Controllers
{

    public class StudentController : Controller
    {
        private readonly InterfaceMyFakeDataService _dummyData;
        public StudentController(InterfaceMyFakeDataService dummyData)
        {
            _dummyData = dummyData;
        }

            public IActionResult Index()
            {
                return View(_dummyData.StudentList);
            }




            public IActionResult ShowDetail(int id)
            {
                Student? student = _dummyData.StudentList.FirstOrDefault(st => st.StudentId == id);
                if (student != null)
                    return View(student);

                return NotFound();

            }

        [HttpGet]
        public IActionResult AddStudent()
        {
            return View();
        }

        [HttpPost]
            public IActionResult AddStudent(Student newStudent)
        {
            if (!ModelState.IsValid)
                return View();

            _dummyData.StudentList.Add(newStudent);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateStudent(int id) 
        {
            Student student = _dummyData.StudentList.FirstOrDefault(st => st.StudentId == id);
            if(student != null)
                return View(student);
            return NotFound();
        }

        [HttpPost]
        public IActionResult UpdateStudent(Student studentChanges)
        {
            Student student = _dummyData.StudentList.FirstOrDefault(st => st.StudentId == studentChanges.StudentId);
            if (student != null)
            {
                student.StudentName = studentChanges.StudentName;
                student.Email = studentChanges.Email;
                student.Course  = studentChanges.Course;
                student.DateEnrolled = studentChanges.DateEnrolled;

            }
            return RedirectToAction("Index");
           
        }
        [HttpGet]
            public IActionResult DeleteStudent(int id)
        {
            Student? student = _dummyData.StudentList.FirstOrDefault(st => st.StudentId ==id);
            if(student != null)
                return View(student);
            return NotFound();
        }

        [HttpPost]
        public IActionResult DeleteStudent(Student removeStudent)
        {
            Student? student = _dummyData.StudentList.FirstOrDefault(st => st.StudentId == removeStudent.StudentId);
            if(student != null)
                _dummyData.StudentList.Remove(student);
            return RedirectToAction("Index");
        }
        
    } 
}
