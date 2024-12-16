using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Domain;

namespace Demo.BL
{
    public interface IService
    {
        //ici on prend customerLight
        public CustomerLight GetCustomer(int id);
    }
}
