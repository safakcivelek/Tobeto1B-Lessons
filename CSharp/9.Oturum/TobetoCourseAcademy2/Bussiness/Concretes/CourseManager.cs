using DataAccess.Concretes;
using Entities.Concretes;

namespace Bussiness.Concretes
{
    public class CourseManager
    {
        public void Get(Course course)
        {
            AdoNetCourseDal courseDal = new AdoNetCourseDal();
            courseDal.Add(course);
        }
    }
}
