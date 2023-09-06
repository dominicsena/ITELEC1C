namespace RamintoITELEC1C.Models

{
    public enum Rank
    {
        Instructor, AssistProf, Prof
    }

    public class Instructor
    {
        public int InstructorId { get; set; }
        public string InstructorName { get; set; }
        public string InstructorEmail { get; set; }
        public DateTime DateHired { get; set; }

        public Rank Rank { get; set; }
    }
}