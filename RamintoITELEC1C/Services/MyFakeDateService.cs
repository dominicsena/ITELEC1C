using RamintoITELEC1C.Models;
using RamintoITELEC1C.Services;
using System;
using System.Security.Cryptography.X509Certificates;


namespace RamintoITELEC1C.Services
{
    public class MyFakeDateService : InterfaceMyFakeDataService
    {
        public List<Student> StudentList { get; }
        public List<Instructor> InstructorList { get; }

        public MyFakeDateService()
        {
            StudentList = new List<Student>
            {
                new Student()
                {
                    StudentId = 2021154552,
                    StudentName = "Dominic Seña",
                    Email = "jabrieldominic.raminto.cics@ust.edu.ph",
                    DateEnrolled = DateTime.Parse("30/08/2023"),
                    Course = Course.BSIT
                }

            };

            InstructorList = new List<Instructor>
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

        }
    }
}
