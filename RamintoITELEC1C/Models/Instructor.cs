namespace RamintoITELEC1C.Models

{
    public enum Rank
    {
        Instructor, AssistantProfessor, AssociateProfessor, Professor
    }

    public class Instructor
    {
        public int InstructorId { get; set; }
        public string InstructorFirstName { get; set; }
        public string InstructorLastName { get; set; }
        public string InstructorEmail { get; set; }

        public bool IsTenured { get; set; }
        public DateTime HiringDate { get; set; }

        public Rank Rank { get; set; }
    }
}