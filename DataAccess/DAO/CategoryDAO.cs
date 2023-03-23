using System;
using System.Collections.Generic;
using System.Linq;
using BussinessObject.Context;
using BussinessObject.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.DAO
{
    public class CategoryDAO
    {
        #region [ Using Singleton ]
        private static CategoryDAO instance = null;
        public static readonly object instanceLock = new object();
        public static CategoryDAO Instance {
            get {
                lock (instanceLock) {
                    if (instance == null) {
                        instance = new CategoryDAO();
                    }
                    return instance;
                }
            }
        }
        #endregion

        #region [ Search Category By StringName ]
        public IEnumerable<Category> FilterCategoryList(string name) {
            var categoryList = new List<Category>();
            try {
                using var context = new SaleManagementContext();
                categoryList = context.Categories.Where(x => x.CategoryName.Contains(name)).ToList(); //, StringComparison.CurrentCultureIgnoreCase
            } catch (Exception ex) {
                throw new Exception(ex.ToString());
            }
            return categoryList;
        }
        #endregion

        #region [ CRUD ]
        public IEnumerable<Category> GetCategoryList() {
            var categoryList = new List<Category>();
            try {
                using var context = new SaleManagementContext();
                categoryList = context.Categories.ToList();
            } catch (Exception ex) {
                throw new Exception(ex.ToString());
            }
            return categoryList;
        }

        public Category GetCategoryById(int id) {
            Category _tempCategory = null;
            try {
                using var context = new SaleManagementContext();
                _tempCategory = context.Categories.FirstOrDefault(x => x.CategoryId == id);
            } catch (Exception ex) {
                throw new Exception(ex.ToString());
            }
            return _tempCategory;
        }

        public void AddCategory(Category _category) {
            try {
                var _tempCategory = this.GetCategoryById(_category.CategoryId);
                if (_tempCategory == null) {
                    using var context = new SaleManagementContext();
                    //context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[User] ON");
                    //context.Database.OpenConnection();
                    context.Categories.Add(_category);
                    context.SaveChanges();
                } else {
                    throw new Exception("The Category Id is already existed.");
                }
            } catch (Exception ex) {
                throw new Exception(ex.ToString());
            }
        }

        public void UpdateCategory(Category _category) {
            try {
                Category tempCategory = this.GetCategoryById(_category.CategoryId);
                if (tempCategory != null) {
                    using var context = new SaleManagementContext();
                    context.Categories.Update(_category);
                    context.SaveChanges();

                } else {
                    throw new Exception("The Category Id is not existed.");

                }
            } catch (Exception ex) {
                throw new Exception(ex.ToString());
            }
        }

        public void RemoveCategory(Category _category) {
            try {
                Category _tempCategory = this.GetCategoryById(_category.CategoryId);
                if (_tempCategory != null) {
                    using var context = new SaleManagementContext();
                    context.Categories.Remove(_tempCategory);
                    context.SaveChanges();
                } else {
                    throw new Exception("The Category Id is not existed.");
                }
            } catch (Exception ex) {
                throw new Exception(ex.ToString());
            }
        }
        #endregion
    }


}
