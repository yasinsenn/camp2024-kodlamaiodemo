using KodlamaIoApp.DataAccess.Abstracts;
using KodlamaIoApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoApp.Business
{
   
    public class CourseManager 
    {
        private ICourseDal _courseDal;

        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        public List<Course> GetAll()
        {
          return _courseDal.GetAll();
        }

        public void Add(Course course)
        {
            _courseDal.Add(course);
            Console.WriteLine(course.CourseId + " id numaralı kurs eklendi." + " Kurs Adı: " + course.CourseName);
        }

        public void Delete(Course course)

        {
            _courseDal.Delete(course);
        }

        public void Update(Course course)
        {
            _courseDal.Update(course);
        }


    }
}
