using DemoBlazorMovil.Models;

namespace DemoBlazorMovil.Services
{
    public class ProductoService
    {
        public readonly List<Producto> lista;

        public ProductoService()
        {
            lista = new List<Producto>()
            {
                new Producto { Id = 1, Nombre = "Martillo", Descripcion = "Martillo de acero", Imagen = "img/matillo.png", Precio = 2500m, Stock = 15 },
                new Producto { Id = 2, Nombre = "Destornillador", Descripcion = "Phillips punta imantada", Imagen = "img/destornillador.png", Precio = 1200m, Stock = 30 },
                new Producto { Id = 3, Nombre = "Caja de clavos", Descripcion = "Clavos 1'' x 500 unidades", Imagen = "img/clavos.png", Precio = 700m, Stock = 50 },
                new Producto { Id = 4, Nombre = "Llave inglesa", Descripcion = "Ajustable 10''", Imagen = "img/llave.png", Precio = 3200m, Stock = 8 },
                new Producto { Id = 5, Nombre = "Cinta métrica", Descripcion = "3 metros retráctil", Imagen = "img/cinta.png", Precio = 950m, Stock = 20 },
                new Producto { Id = 6, Nombre = "Alicate", Descripcion = "Alicate universal 6''", Imagen = "img/alicate.png", Precio = 1800m, Stock = 25 },
                new Producto { Id = 7, Nombre = "Taladro eléctrico", Descripcion = "600W con percusión", Imagen = "img/taladro.png", Precio = 13500m, Stock = 10 },
                new Producto { Id = 8, Nombre = "Sierra manual", Descripcion = "Sierra de mano con mango ergonómico", Imagen = "img/sierra.png", Precio = 2100m, Stock = 12 },
                new Producto { Id = 9, Nombre = "Nivel burbuja", Descripcion = "Nivel 30cm con burbujas horizontal y vertical", Imagen = "img/nivel.png", Precio = 1700m, Stock = 18 },
                new Producto { Id = 10, Nombre = "Llaves Allen", Descripcion = "Juego de 10 llaves métricas", Imagen = "img/allen.png", Precio = 1450m, Stock = 22 }
            };
        }

        public async Task<List<Producto>> GetProductosAsync()
        {
            await Task.Delay(100); // Simula una carga asincrónica
            return lista;
        }

        public async Task<Producto?> GetProductoAsync(int id)
        {
            await Task.Delay(50);
            return lista.FirstOrDefault(p => p.Id == id);
        }

        public async Task AddProductoAsync(Producto producto)
        {
            await Task.Delay(50);
            producto.Id = lista.Any() ? lista.Max(p => p.Id) + 1 : 1;
            lista.Add(producto);
        }

        public async Task DeleteProductoAsync(int id)
        {
            await Task.Delay(50);
            var producto = lista.FirstOrDefault(p => p.Id == id);
            if (producto != null)
            {
                lista.Remove(producto);
            }
        }

        public async Task UpdateProductoAsync(Producto productoActualizado)
        {
            await Task.Delay(50);
            var existente = lista.FirstOrDefault(p => p.Id == productoActualizado.Id);
            if (existente != null)
            {
                existente.Nombre = productoActualizado.Nombre;
                existente.Descripcion = productoActualizado.Descripcion;
                existente.Precio = productoActualizado.Precio;
                existente.Stock = productoActualizado.Stock;
                existente.Imagen = productoActualizado.Imagen;
            }
        }
    }
}
