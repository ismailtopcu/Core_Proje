using Business_Layer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer.Concrete
{
    public class SkillManager : ISkillService
    {
        ISkillDal _skilldal;

        public SkillManager(ISkillDal skilldal)
        {
            _skilldal = skilldal;
        }

        public void TAdd(Skill t)
        {
            _skilldal.Insert(t);
        }

        public void TDelete(Skill t)
        {
            _skilldal.Delete(t);
        }

        public Skill TGetByID(int id)
        {
            return _skilldal.GetByID(id);
        }

        public List<Skill> TGetList()
        {
            return _skilldal.GetList();
        }

        public void TUpdate(Skill t)
        {
            _skilldal.Update(t);
        }
    }
}
