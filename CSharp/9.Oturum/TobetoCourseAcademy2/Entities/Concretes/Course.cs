namespace Entities.Concretes
{
    public class Course
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int InstructorId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }

        public List<CourseInstructor> CourseInstructors { get; set; } // Navigation Property
        public Category Category { get; set; } // Navigation Property
    }
}
