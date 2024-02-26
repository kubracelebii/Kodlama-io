using KodlamaCrud.Entities.Abstract;
using KodlamaCrud.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaCrud.DataAccess.Abstract
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll();
        T Get(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}