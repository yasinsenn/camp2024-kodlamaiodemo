using KodlamaIoApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoApp.DataAccess.Abstracts
{
    public interface ICourseDal
    {
        List<Course> GetAll();

        void Add(Course course);
        void Delete(Course course);

        void Update(Course course);
    }
}
