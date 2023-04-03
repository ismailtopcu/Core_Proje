using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;

public class EfPortfolioDal : GenericRepository<Portfolio>, IPortfolioDal
{
}
