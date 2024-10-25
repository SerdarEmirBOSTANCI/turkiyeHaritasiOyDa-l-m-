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
    public class ikibinyirmidortsecimBl : IikibinyirmidortsecimBl
    {


        IikibinyirmidortsecimDal _ikibinyirmidortsecimDal;

        public ikibinyirmidortsecimBl(IikibinyirmidortsecimDal ikibinyirmidortsecimDal)
        {
            _ikibinyirmidortsecimDal = ikibinyirmidortsecimDal;
        }

        public ikibinyirmidortsecim TGetByID(int id)
        {
            return _ikibinyirmidortsecimDal.GetByID(id);
        }

        public ikibinyirmidortsecim TGetIDbyFilter(int id)
        {
            return _ikibinyirmidortsecimDal.GetbyFilter(x => x.SehirID == id);
        }

        public List<ikibinyirmidortsecim> TGetListByFilter(int id)
        {
            return _ikibinyirmidortsecimDal.GetListbyFiter(x => x.SehirID == id);
        }

        public List<ikibinyirmidortsecim> TList()
        {
            throw new NotImplementedException();
        }
    }
}
