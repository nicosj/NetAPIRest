using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Interfaces
{
    public interface IProductoRepository
    {
        Task<Producto> GetProductoAsync(int id);
        Task<IReadOnlyList<Producto>> GetProductosAsync();
    }
}