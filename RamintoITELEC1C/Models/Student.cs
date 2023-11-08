using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace RamintoITELEC1C.Models

{
   public enum Course
    {
        BSIT,BSCS,BSIS
    }
    public class Student
    {
        [Display(Name = "Student Id")]
        public int StudentId {get;set;}

        [Required(ErrorMessage = "Last name is required.")]
        [Display(Name = "Student Name")]
        public string StudentName { get;set;}

        [Display(Name = "Date Enrolled")]
        [DataType(DataType.Date)]
        public DateTime DateEnrolled { get;set;}

        [Required(ErrorMessage = "Course is required.")]
        [Display(Name = "Course")]
        public Course Course { get;set;}

        [Required(ErrorMessage = "Email is required.")]
        [Display(Name = "Email")]
        public string Email { get;set;}


    }
}
