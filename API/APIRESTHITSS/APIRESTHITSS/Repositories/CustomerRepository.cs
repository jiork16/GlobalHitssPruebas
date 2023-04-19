using APIRESTHITSS.Interfaces;
using APIRESTHITSS.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIRESTHITSS.Repositories
{
    public class CustomerRepository:ICustomerRespository
    {        
        private readonly IRepositoryAsync<Customer> _repository;
        public CustomerRepository( IRepositoryAsync<Customer> repository)
        {
            _repository = repository;
        }
        public async Task<List<Customer>> GetByCIAsync(string ciCustomer)
        {
            return await _repository.Entities.Where(p => p.Ci.StartsWith(ciCustomer)).ToListAsync();
        }
        public async Task<List<Customer>> GetListAsync()
        {
            return await _repository.Entities.ToListAsync();
        }
    }
}
