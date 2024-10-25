using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ikibinonsekizsecimBl : IikibinonsekizsecimBl
    {

        IikibinonsekizsecimDal _ikibinonsekizsecimdal;

        public ikibinonsekizsecimBl(IikibinonsekizsecimDal ikibinonsekizsecimdal)
        {
            _ikibinonsekizsecimdal = ikibinonsekizsecimdal;
        }

        public ikibinonsekizsecim TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public ikibinonsekizsecim TGetIDbyFilter(int id)
        {
            return _ikibinonsekizsecimdal.GetbyFilter(x => x.SehirID == id);
        }

        public List<ikibinonsekizsecim> TGetListByFilter(int id)
        {
            throw new NotImplementedException();
        }

        public List<ikibinonsekizsecim> TList()
        {
            throw new NotImplementedException();
        }
    }
}
