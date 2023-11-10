
using DataAccess.Concretes;
using Entities.Concretes;

namespace Bussiness.Concretes
{
    public class CourseInstructorManager
    {
        public void Get(CourseInstructor courseInstructor)
        {
            AdoNetCourseInsturctorDal courseInsturctorDal = new AdoNetCourseInsturctorDal();
            courseInsturctorDal.Add(courseInstructor);
        }
    }
}
