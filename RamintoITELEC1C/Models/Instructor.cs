using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace RamintoITELEC1C.Models

{
    public enum Rank
    {
        Instructor, AssistantProfessor, AssociateProfessor, Professor
    }
    public enum Status
    {
        Provisionary, Permanent
    }
    public class Instructor
    {
        [Display(Name = "Instructor Id")]
        public int InstructorId { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "First name is required.")]
        public string InstructorFirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last name is required.")]
        public string InstructorLastName { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Email is required.")]
        public string InstructorEmail { get; set; }

        [Display(Name = "Is Tenured")]
        public bool IsTenured { get; set; }

        [Display(Name = "Hiring Date")]
        [DataType(DataType.Date)]
        public DateTime HiringDate { get; set; }

        [Display(Name = "Rank")]
        public Rank Rank { get; set; }
        [Display(Name = "Status")]
        public Status Status { get; set; } 
    }
}