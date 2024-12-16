using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Demo.Orm
{
    public class Data:IData
    {
        DemoOrmContext _dbContext;
        public Data() { 
            _dbContext = new DemoOrmContext();
        }

        public List<Customer> GetCustomers()
        {
            return _dbContext.Customers.Include(
                customer=>customer.Orders
                ).ToList();
        }

    }
}
