using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.Abstract
{
    public interface IProductService // ProductManager implemente ediyor.
    {
        void Add(Product product);
        void Delete(Product product);
        List<Product> GetAll();
        List<Product> GetProductByCategory(int categoryId);
        List<Product> GetProductsByProductName(string productName);
        void Update(Product product);
    }
}
