namespace RamintoITELEC1C.Models

{
   public enum Course
    {
        BSIT,BSCS,BS
    }
    public class Student
    {
        public int StudentId {get;set;}
        
        public string StudentName { get;set;}

        public DateTime DateEnrolled { get;set;}

        public Course Course { get;set;}

        public string Email { get;set;}


    }
}
