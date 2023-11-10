using Entities.Concretes;

namespace DataAccess.Concretes
{
    public class AdoNetCourseDal
    {
        public void Add(Course course)
        {           
            Console.WriteLine($"'{course.Name}' adlı kurs Ado.Net kullanılarak veritabanına eklendi...");
        }
    }
}
