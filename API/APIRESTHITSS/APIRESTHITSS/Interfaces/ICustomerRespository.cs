using APIRESTHITSS.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APIRESTHITSS.Interfaces
{
    public interface ICustomerRespository
    {
        Task<List<Customer>> GetByCIAsync(string ciCustomer);
        Task<List<Customer>> GetListAsync();
    }
}
