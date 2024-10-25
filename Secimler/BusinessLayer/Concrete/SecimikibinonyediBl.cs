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
    public class SecimikibinonyediBl : ISecimikibinonyediBl
    {

        ISecimikibinonyediDal secimikibinonyediDal;

        public SecimikibinonyediBl(ISecimikibinonyediDal secimikibinonyediDal)
        {
            this.secimikibinonyediDal = secimikibinonyediDal;
        }

        public ikibinonyedisecim TGetByID(int id)
        {
            return secimikibinonyediDal.GetByID(id);
        }

        public ikibinonyedisecim TGetIDbyFilter(int id)
        {
            return secimikibinonyediDal.GetbyFilter(x => x.SehirID == id);
        }

        public List<ikibinonyedisecim> TGetListByFilter(int id)
        {
            throw new NotImplementedException();
        }

        public List<ikibinonyedisecim> TList()
        {
            throw new NotImplementedException();
        }
    }
}
