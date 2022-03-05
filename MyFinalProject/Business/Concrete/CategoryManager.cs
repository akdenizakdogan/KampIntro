using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;  //Bağımlılığı crop injector ile cözüyorum. Referans üzerinden bağımlıyım. Dataaccesste ne yaparsan yap.

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            //İş Kodları
            return _categoryDal.GetAll();

        }
        // Select * from Categories where CategoryId=3 SQL de
        public Category GetById(int categoryId)
        {
            return _categoryDal.Get(c => c.CategoryId == categoryId);
        }

    }
}
