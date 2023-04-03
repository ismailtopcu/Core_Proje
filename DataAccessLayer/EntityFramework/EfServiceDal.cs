using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;

public class EfServiceDal : GenericRepository<Service>, IServiceDal
{
}
