using Models.API.Global.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.API.Interfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GET();
        Category Get(int id);
        void Insert(Category category);
        void Update(int id, Category category);
    }
}
