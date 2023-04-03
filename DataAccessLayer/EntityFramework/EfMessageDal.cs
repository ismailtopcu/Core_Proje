using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;

public class EfMessageDal : GenericRepository<Message>, IMessageDal
{
}
