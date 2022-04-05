using BusinessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class HeaderManager:IHeaderService
    {
        IHeaderDal _headerDal;

        public HeaderManager(IHeaderDal headerDal)
        {
            _headerDal = headerDal;
        }

        public void AddHeader(Header header)
        {
            _headerDal.Insert(header);
        }

        public void DeleteHeader(Header header)
        {
            _headerDal.Delete(header);
        }

        public Header GetbyID(int id)
        {
            return _headerDal.Find(x=>x.HeaderID== id);
        }

        public List<Header> GetHeaders()
        {
            return _headerDal.List();
        }

        public void UpdateHeader(Header header)
        {
            _headerDal.Update(header);
        }
    }
}
