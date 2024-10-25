using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {

        Context c = new Context();

        public T GetbyFilter(Expression<Func<T, bool>> filter)
        {
            return c.Set<T>().Where(filter).FirstOrDefault();
        }

        public T GetByID(int id)
        {
           return c.Set<T>().Find(id);
        }

        public List<T> GetList()
        {
            return c.Set<T>().ToList();
        }

        public List<T> GetListbyFiter(Expression<Func<T, bool>> filter)
        {
            return c.Set<T>().Where(filter).ToList();
        }
    }
}
