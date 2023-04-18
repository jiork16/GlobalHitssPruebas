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
        private readonly GLOBALHITSSContext _dbContext;
        public CustomerRepository(GLOBALHITSSContext dbContext, IRepositoryAsync<Customer> repository)
        {
            _repository = repository;
            _dbContext = dbContext;
        }
        public async Task<int> InsertAsync(Customer customer)
        {
            await _repository.AddAsync(customer);
            return customer.Id;
        }
        public async Task UpdateAsync(Customer customer)
        {
            await _repository.UpdateAsync(customer);
        }
        public async Task<Customer> GetByCIAsync(string ciCustomer)
        {
            return await _dbContext.Customers.Where(p => p.Ci == ciCustomer).FirstAsync();

        }
        public async Task<List<Customer>> GetListAsync()
        {
            return await _repository.Entities.ToListAsync();
        }
    }
}
