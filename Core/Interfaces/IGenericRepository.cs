using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Interfaces
{
    public interface IGenericRepository<T> where T : Base
    {
        Task<T> GetByIdAsync(int id);

        Task<IReadOnlyList<T>> GetallAsync();
    }
}