using BussinesLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Concrete
{
    public class ExperienceManager : IExperienceService
    {
        IExperienceDal _experinecedal;

        public ExperienceManager(IExperienceDal experinecedal)
        {
            _experinecedal = experinecedal;
        }

        public void TAdd(Experience t)
        {
            _experinecedal.Insert(t);
        }

        public void TDelete(Experience t)
        {
            _experinecedal.Delete(t);
        }

        public Experience TGetByID(int id)
        {
            return _experinecedal.GetByID(id);
        }

        public List<Experience> TGetList()
        {
            return _experinecedal.GetList();
        }

        public void TUpdate(Experience t)
        {
            _experinecedal.Update(t);
        }
    }
}
