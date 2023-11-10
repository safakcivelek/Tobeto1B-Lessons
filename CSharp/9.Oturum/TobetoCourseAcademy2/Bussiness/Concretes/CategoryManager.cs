using DataAccess.Concretes;
using Entities.Concretes;

namespace Bussiness.Concretes
{
    public class CategoryManager
    {
        public void Get(Category category)
        {
            AdoNetCategoryDal categoryDal = new AdoNetCategoryDal();
            categoryDal.Add(category);
        }
    }
}
