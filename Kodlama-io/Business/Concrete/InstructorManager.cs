using KodlamaCrud.DataAccess.Abstract;
using KodlamaCrud.Entities.Concrete;
using KodlamaCrud.Business.Abstract;
using KodlamaCrud.DataAccess.Abstract;
using KodlamaCrud.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaCrud.Business.Concrete
{
    public class InstructorManager : IInstructorService
    {
        private readonly IInstructorDal _instructorDal;
        public InstructorManager(IInstructorDal instructorDal)
        {
            _instructorDal = instructorDal;
        }

        public void Add(Instructor instructor)
        {
            _instructorDal.Add(instructor);
        }



        public void Delete(int id)
        {
            _instructorDal.Delete(id);
        }

        public List<Instructor> GetAll()
        {
            return _instructorDal.GetAll();
        }

        public void Update(Instructor instructor)
        {
            _instructorDal.Update(instructor);
        }



        List<Instructor> IInstructorService.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}