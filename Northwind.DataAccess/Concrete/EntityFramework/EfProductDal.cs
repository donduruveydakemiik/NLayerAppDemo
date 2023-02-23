using Northwind.DataAccess.Abstract;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityFrameworkBase<Product,NorthwindContext>, IProductDal// data acsess layer = Veri tabanıyla yapılmak istenen metodlar ve işlemler
    {
            
    }
}
