using Demo.Domain;
using Demo.Orm;
using System.Linq;

namespace Demo.BL
{
    /// <summary>
    /// 
    /// </summary>
    public class Service : IService
    {
        private readonly IData _data;
        /// <summary>
        /// Construteur parametrer 
        /// utiliser de l'injection de dépandce 
        /// </summary>
        /// <param name="data"></param>

        public Service(IData data)
        {
            _data = data; 
        }

       /// <summary>
       /// a partir de l'id du client 
       /// on va rechercher la derniere date de commande 
       /// 
       /// </summary>
       /// <param name="id"></param>
       /// <returns></returns>
        public CustomerLight GetCustomer(int id)
        {
            return _data.GetCustomers()
                .Where(c => c.Id == id)
                .Select(c => new CustomerLight
                {
                    Id = c.Id,
                    Name = c.Name,
                    LastOrderDate = c.Orders.Last().Date,
                })
                .First();
        }
    }
}
