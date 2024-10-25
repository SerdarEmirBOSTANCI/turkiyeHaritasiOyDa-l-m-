using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGenericBl<T> where T : class
    {
        List<T> TList();
        List<T> TGetListByFilter(int id);
        T TGetByID(int id);
        T TGetIDbyFilter(int id);


    }
}
