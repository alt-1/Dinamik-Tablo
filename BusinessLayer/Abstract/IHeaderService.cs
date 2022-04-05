using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IHeaderService
    {
        List<Header> GetHeaders();
        Header GetbyID (int id);
        void AddHeader(Header header);
        void DeleteHeader(Header header);
        void UpdateHeader(Header header);
    }
}
