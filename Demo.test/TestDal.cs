﻿using Demo.Orm;

namespace Demo.test
{
    [TestClass]
    public sealed class TestDal
    {
        [TestMethod]
        public void TestMethod1()
        {

            Data data= new Data();
            var result = data.GetCustomers();
            Assert.IsNotNull(result);

        }
    }
}
