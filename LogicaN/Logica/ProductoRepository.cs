using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using LogicaN.Data;
using Microsoft.EntityFrameworkCore;

namespace LogicaN.Logica
{
    public class ProductoRepository : IProductoRepository
    {
        private readonly  NegocioDbContext _context;
        public ProductoRepository(NegocioDbContext context)
        {
            _context= context;
        }
        public async Task<Producto> GetProductoAsync(int id)
        {
            return await _context.Producto
                .Include(p => p.Marca)
                .Include(p => p.Categoria)
                .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<IReadOnlyList<Producto>> GetProductosAsync()
        {
           return await _context.Producto
               .Include(p => p.Marca)
               .Include(p => p.Categoria)
               .ToListAsync();
        }
    }
}