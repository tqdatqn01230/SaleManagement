using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.IRepository
{
    public interface IProductRepository
    {
        public IEnumerable<Product> FilterProductListByName(string name);
        public IEnumerable<Product> GetProductList();
        public Product GetProductById(int id);
        public void AddProduct(Product _Product);
        public void UpdateProduct(Product _Product);
        public void RemoveProduct(Product _Product);
        public IEnumerable<Product> FilterProductListById(string id);
        public IEnumerable<Product> FilterProductListByPrice(string price);
        public IEnumerable<Product> FilterProductListByNoInstock(string stock);
    }
}
