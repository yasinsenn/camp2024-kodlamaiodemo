using KodlamaIoApp.DataAccess.Abstracts;
using KodlamaIoApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoApp.Business
{
    public class Instructormanager

    {
        IInstructorDal _instructorDal;

        public Instructormanager(IInstructorDal instructorDal)
        {
            _instructorDal = instructorDal;
        }

        public void Add(Instructor instructor)
        {
            _instructorDal.Add(instructor);
        }

        public void Delete(Instructor instructor)
        {
            _instructorDal.Delete(instructor);
        }

        public void Update(Instructor instructor)
        {
            _instructorDal.Update(instructor);
        }

        public List<Instructor> GetAll(Instructor instructor) {

           return _instructorDal.GetAll();
        }
    }
}
