using DataAccess_Layer.Abstract;
using DataAccess_Layer.Concrete;
using DataAccess_Layer.Repositories;
using Entity_Layer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess_Layer.EntityFramework
{
    public class EfCustomerDal : GenericRepository<Customer>, ICustomerDal
    {
        public List<Customer> GetCustomerListWithJob()
        {
            using (Context c = new Context())
            {
                return c.Customers.Include(x => x.Job).ToList();
            }
        }
    }
}
