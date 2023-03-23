using BussinessObject.Models;
using DataAccess.DAO;
using DataAccess.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class ProductRepository : IProductRepository
    {
        public void AddProduct(Product _Product) => ProductDAO.Instance.AddProduct(_Product);

        public IEnumerable<Product> FilterProductListByName(string name) => ProductDAO.Instance.FilterProductListByName(name);

        public IEnumerable<Product> FilterProductListById(string id) => ProductDAO.Instance.FilterProductListById(id);

        public Product GetProductById(int id) => ProductDAO.Instance.GetProductById(id);

        public IEnumerable<Product> GetProductList() => ProductDAO.Instance.GetProductList();

        public void RemoveProduct(Product _Product) => ProductDAO.Instance.RemoveProduct(_Product);

        public void UpdateProduct(Product _Product) => ProductDAO.Instance.UpdateProduct(_Product);

        public IEnumerable<Product> FilterProductListByPrice(string price) => ProductDAO.Instance.FilterProductListByPrice(price);

        public IEnumerable<Product> FilterProductListByNoInstock(string stock) => ProductDAO.Instance.FilterProductListByNoInstock(stock);
    }
}
