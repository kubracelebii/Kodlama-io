using KodlamaCrud.DataAccess.Abstract;
using KodlamaCrud.Entities.Concrete;
using KodlamaCrud.DataAccess.Abstract;
using KodlamaCrud.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaCrud.Business.Concrete
{
    public class CategoryManager
    {

        ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }



        public void Add(Category category)
        {
            _categoryDal.Add(category);
        }

        public void Delete(int id)
        {
            _categoryDal.Delete(id);
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }


        public void Update(Category category)
        {
            _categoryDal.Update(category);
        }
    }
}