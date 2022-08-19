using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;
using Core.Entities;
using LogicaN.Data;
using Microsoft.Extensions.Logging;


namespace LogicaN.CargarData
{
    public class NegocioDbContextData
    {
        public static async Task CargarDataAsync(NegocioDbContext context, ILoggerFactory iloggerFactory)
        {
            try
            {
                if (!context.Marca.Any())
                {
                    var marcaData = File.ReadAllText("../LogicaN/CargarData/marca.json");
                    var marcas = JsonSerializer.Deserialize<List<Marca>>(marcaData);
                    foreach (var marca in marcas)
                    {
                        context.Marca.Add(marca);
                    }

                    await context.SaveChangesAsync();
                }
                if (!context.Categoria.Any())
                {
                    var categoriaData = File.ReadAllText("../LogicaN/CargarData/categoria.json");
                    var categorias = JsonSerializer.Deserialize<List<Categoria>>(categoriaData);
                    foreach (var categoria in categorias)
                    {
                        context.Categoria.Add(categoria);
                    }

                    await context.SaveChangesAsync();
                }
                if (!context.Producto.Any())
                {
                    var productoData = File.ReadAllText("../LogicaN/CargarData/producto.json");
                    var productos = JsonSerializer.Deserialize<List<Producto>>(productoData);
                    foreach (var producto in productos)
                    {
                        context.Producto.Add(producto);
                    }

                    await context.SaveChangesAsync();
                }
            }
            catch (Exception e)
            {
                var logger = iloggerFactory.CreateLogger<NegocioDbContext>();
                logger.LogError(e.Message);
            }
        }
    }
}