using KodlamaIoApp.DataAccess.Abstracts;
using KodlamaIoApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoApp.DataAccess.Concrete
{
    internal class CategoryDal : ICategoryDal
    {
        private List<Category> categories;
        public CategoryDal()
        {
            categories = new List<Category>();
        }

        public void Add(Category category)
        {
            categories.Add(category);
            
        }


        public void Delete(Category category)
        {
            var deleteCategory = categories.FirstOrDefault(c => c.CategoryId == category.CategoryId);

            if (deleteCategory != null)
            {
                categories.Remove(category);
            }
            else
            {
                Console.WriteLine("Girilen Id numarası bulunamadı");
            }
        }

        public List<Category> GetAll()
        {
            foreach (var category in categories)
            {
                Console.WriteLine("Kategori Id: " + category.CategoryId + " Kategori Adı: " + category.CategoryName);
            }
            return categories;
        }


        public void Update(Category category)
        {

            var updateCategory = categories.FirstOrDefault(c => c.CategoryId == category.CategoryId);
            if (updateCategory != null)
            {
                updateCategory.CategoryId = category.CategoryId;
                updateCategory.CategoryName = category.CategoryName;
            }
            else
            {
                Console.WriteLine("Güncellenmek istenen kategori bulunamadı");
            }


        }

    }
}
