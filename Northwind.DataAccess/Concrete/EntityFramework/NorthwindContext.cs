using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Concrete.EntityFramework
{
    public class NorthwindContext : DbContext // veri tabanıyla bağlantı kurulması için gerekli işlemler Entityframework 
    {
        public DbSet<Product> Products { get; set; } // Dbset döndüren product olan ve Products table içinde arayan 
        public DbSet<Category> Categories { get; set; }
    }
}
