using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategorManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;
        public Category GetById(int id)
        {
            return _categoryDal.GetById(id);
        }

        public void TDelete(Category t)
        {
            _categoryDal.Delete(t);
        }

        public List<Category> TGetList()
        {
            return _categoryDal.GetList();
        }

        public void TInsert(Category t)
        {
            _categoryDal.Insert(t);
        }

        public void TUpdate(Category t)
        {
            _categoryDal.Update(t);
        }
    }
}
