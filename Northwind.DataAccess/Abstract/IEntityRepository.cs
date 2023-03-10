using Northwind.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.Abstract
{
    public interface IEntityRepository<T> where T : class,IEntity, new()
    {
       List<T> GetAll(Expression<Func<T, bool>> filter=null); //ürünü filte yazarak getirebilir isterse
        T Get(Expression<Func<T, bool >> filter);
        void Delete(T entity);
        void Update(T entity);
        void Add(T entity);
    }
}
