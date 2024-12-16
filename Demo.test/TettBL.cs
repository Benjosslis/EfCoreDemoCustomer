using Demo.Orm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.BL;
using Moq;

namespace Demo.test
{
    [TestClass]
    public sealed class TettBL
    {
        [TestMethod]
        public void TestMethod2()
        {

           Data data = new Data();

            Service service = new Service(data);

            var result = service.GetCustomer(1);
            Assert.IsNotNull(result);
        }



    }
}
