
namespace Intro
{
    public class CourseTeacher
    {
        public int Id { get; set; }
        public int TeacherId { get; set; }
        public int CourseId { get; set; }

        public Course Course { get; set; } // Navigation Property
        public Teacher Teacher { get; set; } // Navigation Property
    }
}
