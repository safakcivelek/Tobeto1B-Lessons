
namespace Intro
{
    public class Course 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }
        public int CategoryId { get; set; }
        

        public List<CourseTeacher> CourseTeachers { get; set; } // Navigation Property
        public Category Category { get; set; } // Navigation Property
    }
}
