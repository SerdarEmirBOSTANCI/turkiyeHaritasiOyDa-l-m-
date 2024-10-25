using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
   public interface IGenericDal<T> where T : class
    {
        List<T> GetList();
        T GetByID(int id);
        List<T> GetListbyFiter(Expression<Func<T, bool>> filter);
        T GetbyFilter(Expression<Func<T, bool>> filter);
    }
}
