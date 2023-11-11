
namespace Intro
{
    public class Teacher
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
       

        public List<CourseTeacher> CourseTeachers { get; set; } // Navigation Property 
    }
}
