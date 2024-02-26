using KodlamaCrud.Entities.Concrete;
using KodlamaCrud.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaCrud.Business.Abstract
{
    internal interface IInstructorService
    {
        List<Instructor> GetAll();
        void Add(Instructor instructor);
        void Update(Instructor instructor);
        void Delete(int id);
    }
}