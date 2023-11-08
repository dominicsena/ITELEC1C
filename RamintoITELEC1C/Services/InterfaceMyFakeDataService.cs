using RamintoITELEC1C.Models;
using RamintoITELEC1C.Services;



namespace RamintoITELEC1C.Services

{
    public interface InterfaceMyFakeDataService
    {
        public List<Student> StudentList { get; }
        public List<Instructor> InstructorList { get; }
    }
}
