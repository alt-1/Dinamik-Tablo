using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IDataService
    {
        List<Data> GetDatas();
        void AddData(Data data);
        void DeleteData(Data data);
        void UpdateData(Data data);
    }
}
