using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;

namespace LogicaN.Logica
{
    public class GenericRepository <T> : IGenericRepository<T>where T : Base
    {
        public Task<T> GetByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IReadOnlyList<T>> GetallAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}