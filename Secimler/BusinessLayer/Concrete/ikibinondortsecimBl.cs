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
    public class ikibinondortsecimBl : IikibinondortsecimBl
    {

        IikibinondortsecimDal _ikibinondortsecimdal;

        public ikibinondortsecimBl(IikibinondortsecimDal ikibinondortsecimdal)
        {
            _ikibinondortsecimdal = ikibinondortsecimdal;
        }

        public ikibinondortsecim TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public ikibinondortsecim TGetIDbyFilter(int id)
        {
            return _ikibinondortsecimdal.GetbyFilter(x => x.SehirID == id);
        }

        public List<ikibinondortsecim> TGetListByFilter(int id)
        {
            return _ikibinondortsecimdal.GetListbyFiter(x => x.SehirID == id);
        }

        public List<ikibinondortsecim> TList()
        {
            throw new NotImplementedException();
        }
    }
}
