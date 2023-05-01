using Business_Layer.Abstract;
using DataAccess_Layer.Abstract;
using Entity_Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer.Concrete
{
    public class JobManager : IGenericService<Job>
    {
        IJobDal _jobDal;
        public JobManager(IJobDal jobDal)
        {
            _jobDal = jobDal;
        }
        public Job GetById(int id)
        {
            return _jobDal.GetById(id);
        }

        public void TDelete(Job t)
        {
            _jobDal.Delete(t);
        }

        public List<Job> TGetList()
        {
            return _jobDal.GetList();
        }

        public void TInsert(Job t)
        {
            _jobDal.Insert(t);
        }

        public void TUpdate(Job t)
        {
            _jobDal.Update(t);
        }
    }
}
