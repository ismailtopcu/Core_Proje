using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;

public class EfSkillDal : GenericRepository<Skill>, ISkillDal
{
}
