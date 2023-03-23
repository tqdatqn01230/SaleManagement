using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.IRepository
{
    public interface ICategoryRepository
    {
        public IEnumerable<Category> FilterCategoryList(string name);
        public IEnumerable<Category> GetCategoryList();
        public Category GetCategoryById(int id);
        public void AddCategory(Category _category);
        public void UpdateCategory(Category _category);
        public void RemoveCategory(Category _category);

    }
}
