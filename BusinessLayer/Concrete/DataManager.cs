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
    public class DataManager:IDataService
    {
        IDataDal _dataDal;

        public DataManager(IDataDal dataDal)
        {
            _dataDal = dataDal;
        }

        public void AddData(Data data)
        {
            _dataDal.Insert(data);
        }

        public void DeleteData(Data data)
        {
           _dataDal.Delete(data);
        }

        public List<Data> GetDatas()
        {
            return _dataDal.List();
        }

        public void UpdateData(Data data)
        {
            _dataDal.Update(data);
        }
    }
}
