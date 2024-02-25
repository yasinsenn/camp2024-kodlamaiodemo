﻿using KodlamaIoApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoApp.DataAccess.Abstracts
{
    public interface ICategoryDal
    {
        List<Category> GetAll();

        void Add(Category category);
        void Delete(Category category);
        void Update(Category category);
    }
}
