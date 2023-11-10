namespace Entities.Concretes
{
    public class Instructor
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        public List<CourseInstructor> CourseInstructors { get; set; } // Navigation Property 
    }
}
