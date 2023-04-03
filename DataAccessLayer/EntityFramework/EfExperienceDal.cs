using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;

public class EfExperienceDal : GenericRepository<Experience>, IExperienceDal
{
}
