using KodlamaCrud.Entities.Concrete;
using KodlamaCrud.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaCrud.DataAccess.Abstract
{
    public interface ICategoryDal : IEntityRepository<Category>
    {
        void Add(Category entity);
        void Update(Category category);
    }
}