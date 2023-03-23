using BussinessObject.Models;
using DataAccess.DAO;
using DataAccess.IRepository;
using System.Collections.Generic;

 
namespace DataAccess.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        public void AddCategory(Category _category) => CategoryDAO.Instance.AddCategory(_category);

        public IEnumerable<Category> FilterCategoryList(string name) => CategoryDAO.Instance.FilterCategoryList(name);

        public Category GetCategoryById(int id) => CategoryDAO.Instance.GetCategoryById(id);

        public IEnumerable<Category> GetCategoryList() => CategoryDAO.Instance.GetCategoryList();

        public void RemoveCategory(Category _category) => CategoryDAO.Instance.RemoveCategory(_category);

        public void UpdateCategory(Category _category) => CategoryDAO.Instance.UpdateCategory(_category);
    }
}
