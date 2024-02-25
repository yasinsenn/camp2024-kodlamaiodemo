using KodlamaIoApp.DataAccess.Abstracts;
using KodlamaIoApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoApp.DataAccess.Concrete
{
    internal class InstructorDal : IInstructorDal
    {
        List<Instructor> instructors;
        public InstructorDal()
        {
            instructors = new List<Instructor>();
        }
        public void Add(Instructor instructor)
        {
            instructors.Add(instructor);
        }

        public void Delete(Instructor instructor)
        {
            var deleteInstructor = instructors.FirstOrDefault(i => i.InsructorId == instructor.InsructorId);
            if (deleteInstructor != null)
            {
                instructors.Remove(instructor);
            }
            else
            {
                Console.WriteLine("Silinmek istenen eğitmen bulunamadı");
            }
        }

        public List<Instructor> GetAll()
        {
            foreach (var instructor in instructors)
            {
                Console.WriteLine("Eğitmen Id: " + instructor.InsructorId + " Eğitmen Adı: " + instructor.InstructorName);
            }
            return instructors;
        }

        public void Update(Instructor instructor)
        {
            var updateInstructor = instructors.FirstOrDefault(i => i.InsructorId == instructor.InsructorId);
            if(updateInstructor != null)
            {
                updateInstructor.InsructorId = instructor.InsructorId;
                updateInstructor.InstructorName = instructor.InstructorName;
                updateInstructor.InstructorEmail = instructor.InstructorEmail;

            }else
            {
                Console.WriteLine("Güncellenmek istenen eğitmen bulunamadı");
            }
        }
    }
}
