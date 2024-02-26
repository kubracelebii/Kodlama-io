using KodlamaCrud.Entities.Concrete;
using KodlamaCrud.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaCrud.Business.Abstract
{
    internal interface ICategoryService
    {
        List<Category> GetAll();
        void Add(Category category);
        void Update(Category category);
        void Delete(int id);
    }
}