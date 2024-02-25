using KodlamaIoApp.Business;
using KodlamaIoApp.DataAccess.Concrete;
using KodlamaIoApp.Entities;


internal class Program
{
    private static void Main(string[] args)
    {
        CourseManager courseManager = new CourseManager(new CourseDal());
        Course course = new Course();
        course.CourseId = 1;
        course.CourseName = "C#";
        course.Description = "2024 Yazılım Geliştirme Kampı";
        course.Price = 10;
        course.CategoryId = 1;
        course.InstructorId = 1;

        Course course2 = new Course();
        course.CourseId = 2;
        course.CourseName = "Java";
        course.Description = "2024 Yazılım Geliştirme Kampı";
        course.Price = 20;
        course.CategoryId = 1;
        course.InstructorId = 1;
        courseManager.Add(course);
        //courseManager.Add(course2);


        CategoryManager categoryManager = new CategoryManager(new CategoryDal());
        Category category = new Category();
        category.CategoryId = 1;
        category.CategoryName = "Yazılım";

        Category category1 = new Category();
        category1.CategoryId = 2;
        category1.CategoryName = "Siber Güvenlik";
        Category category2 = new Category();
        category2.CategoryId = 3;
        category2.CategoryName = "Dijital Pazarlama";
    }
}

//categoryManager.Add(category);  
//categoryManager.Add(category1);
//categoryManager.Update(category2);

//categoryManager.Delete(category);
//categoryManager.GetAll();
