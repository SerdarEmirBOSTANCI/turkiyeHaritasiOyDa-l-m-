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
    public class ikibinyirmiucsecimbirBl : IikibinyirmiucsecimbirBl
    {

        IikibinyirmiucsecimbirDal _ikibinyirmiucsecimbir;


        public ikibinyirmiucsecimbirBl(IikibinyirmiucsecimbirDal ikibinyirmiucsecimbir)
        {
            _ikibinyirmiucsecimbir = ikibinyirmiucsecimbir;
        }

        public ikibinyirmiucsecimbir TGetByID(int id)
        {
            return _ikibinyirmiucsecimbir.GetByID(id);
        }

        public ikibinyirmiucsecimbir TGetIDbyFilter(int id)
        {
            return _ikibinyirmiucsecimbir.GetbyFilter(x => x.SehirID == id);
        }

        public List<ikibinyirmiucsecimbir> TGetListByFilter(int id)
        {
            return _ikibinyirmiucsecimbir.GetListbyFiter(x => x.SehirID == id);
        }

        public List<ikibinyirmiucsecimbir> TList()
        {
          return _ikibinyirmiucsecimbir.GetList();
        }
    }
}
