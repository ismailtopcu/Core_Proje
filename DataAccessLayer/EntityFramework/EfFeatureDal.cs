using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;

public class EfFeatureDal : GenericRepository<Feature>, IFeatureDal
{
}
