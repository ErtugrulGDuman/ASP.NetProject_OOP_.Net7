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
    public class CustomerManager : IGenericService<Customer>
    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public Customer GetById(int id)
        {
            return _customerDal.GetById(id);
        }

        public List<Customer> GetCustomersListWithJob()
        {
            return _customerDal.GetCustomerListWithJob();
        }

        public void TDelete(Customer t)
        {
            _customerDal.Delete(t);
        }

        public List<Customer> TGetList()
        {
            return _customerDal.GetList();
        }

        public void TInsert(Customer t)
        {
            _customerDal.Insert(t);
        }

        public void TUpdate(Customer t)
        {
            _customerDal.Update(t);
        }
    }
}
