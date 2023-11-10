using DataAccess.Concretes;
using Entities.Concretes;

namespace Bussiness.Concretes
{
    public class InstructorManager
    {
        public void Get(Instructor instructor)
        {
            AdoNetInstructorDal instructorDal = new AdoNetInstructorDal();
            instructorDal.Add(instructor);
        }
    }
}
