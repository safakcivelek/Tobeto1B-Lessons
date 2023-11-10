using DataAccess.Concretes;
using Entities.Concretes;

namespace Business.Concretes
{
    public class CategoryManager
    {
        public void Add(Category category)
        {
            AdoNetCategoryDal categoryDal = new AdoNetCategoryDal();

        }
    }
    
}
