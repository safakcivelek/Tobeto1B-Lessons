using Entities.Concretes;

namespace DataAccess.Concretes
{
    public class AdoNetCategoryDal
    {
        public void Add(Category category)
        {
            Console.WriteLine($"'{category.Name}' adlı kategori Ado.Net kullanılarak veritabanına eklendi...");
        }
    }
}
