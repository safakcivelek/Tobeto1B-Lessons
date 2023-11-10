using Entities.Concretes;

namespace DataAccess.Concretes
{
    public class AdoNetInstructorDal
    {
        public void Add(Instructor instructor)
        {
            Console.WriteLine($"'{instructor.FirstName} {instructor.LastName}' isimli eğitmen Ado.Net kullanılarak veritabanına eklendi...");           
        }
    }
}
