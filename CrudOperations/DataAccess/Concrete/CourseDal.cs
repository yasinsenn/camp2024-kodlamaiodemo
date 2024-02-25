using KodlamaIoApp.DataAccess.Abstracts;
using KodlamaIoApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoApp.DataAccess.Concrete
{
    public class CourseDal : ICourseDal
    {
        private List<Course> courses;
        public CourseDal()
        {
            courses = new List<Course>();
        }
        public void Add(Course course)
        {
            courses.Add(course);
        }

        public void Update(Course course)
        {
            var updateCourse = courses.FirstOrDefault(c => c.CourseId == course.CourseId);
            if (updateCourse != null)
            {
                updateCourse.CourseId = course.CourseId;
                updateCourse.CourseName = course.CourseName;
                updateCourse.Description = course.Description;
                updateCourse.Price = course.Price;
            }
            else
            {
                Console.WriteLine("Güncellenmek istenen kurs bulunamadı");
            }

        }

        public void Delete(Course course)

        {
            var deleteCourse = courses.FirstOrDefault(c => c.CourseId == course.CourseId);
            if (deleteCourse != null)
            {
                courses.Remove(deleteCourse);
            }
            else
            {
                Console.WriteLine("Silinmek numarası bulunamadı");
            }


        }

        public List<Course> GetAll()
        {
            foreach (var course in courses)
            {
                Console.WriteLine("Kurs Id: " + course.CourseId + " Kurs Adı: " + course.CourseName);
            }
            return courses;
        }
    }
}
