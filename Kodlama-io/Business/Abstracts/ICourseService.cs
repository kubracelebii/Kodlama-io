using KodlamaCrud.Entities.Concrete;
using KodlamaCrud.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaCrud.Business.Abstract
{
    internal interface ICourseService
    {
        List<Course> GetAll();
        void Add(Course course);
        void Update(Course course);
        void Delete(int id);
    }
}