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
    public class ikibinyirmiucsecimikiBl : IikibinyirmiucsecimikiBl
    {

        IikibinyirmiucsecimikiDal _ikibinyirmiucsecimikiDal;

        public ikibinyirmiucsecimikiBl(IikibinyirmiucsecimikiDal ikibinyirmiucsecimikiDal)
        {
            _ikibinyirmiucsecimikiDal = ikibinyirmiucsecimikiDal;
        }

        public ikibinyirmiucsecimiki TGetByID(int id)
        {
            return _ikibinyirmiucsecimikiDal.GetByID(id);
        }

        public ikibinyirmiucsecimiki TGetIDbyFilter(int id)
        {
            return _ikibinyirmiucsecimikiDal.GetbyFilter(x=>x.SehirID==id);
        }

        public List<ikibinyirmiucsecimiki> TGetListByFilter(int id)
        {
            throw new NotImplementedException();
        }

        public List<ikibinyirmiucsecimiki> TList()
        {
            return _ikibinyirmiucsecimikiDal.GetList();
        }
    }
}
