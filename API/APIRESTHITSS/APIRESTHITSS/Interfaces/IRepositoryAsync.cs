using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIRESTHITSS.Interfaces
{
    public interface IRepositoryAsync<T> where T : class
    {
        IQueryable<T> Entities { get; }
        Task<List<T>> GetAllAsync();
        Task<List<T>> GetPagedReponseAsync(int pageNumber, int pageSize);
    }
}
