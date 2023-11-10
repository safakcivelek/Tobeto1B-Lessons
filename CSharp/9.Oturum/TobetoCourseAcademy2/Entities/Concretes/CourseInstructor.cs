namespace Entities.Concretes
{
    public class CourseInstructor
    {
        public int Id { get; set; }
        public int InstuctorId { get; set; }
        public int CourseId { get; set; }

        public Course Course { get; set; } // Navigation Property
        public Instructor Instructor { get; set; } // Navigation Property
    }
}
