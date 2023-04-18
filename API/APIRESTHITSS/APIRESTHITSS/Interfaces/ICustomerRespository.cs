using APIRESTHITSS.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APIRESTHITSS.Interfaces
{
    public interface ICustomerRespository
    {
        Task<int> InsertAsync(Customer customer);
        Task UpdateAsync(Customer customer);
        Task<Customer> GetByCIAsync(string ciCustomer);
        Task<List<Customer>> GetListAsync();       
    }
}
