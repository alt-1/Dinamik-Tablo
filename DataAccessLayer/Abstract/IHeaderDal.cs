using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public interface IHeaderDal:IRepository<Header>
    {
    }
}