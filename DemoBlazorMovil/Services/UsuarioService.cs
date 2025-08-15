using DemoBlazorMovil.Models;

namespace DemoBlazorMovil.Services
{
    public class UsuarioService
    {
        private List<Usuario> usuarios = new()
        {
            new Usuario { Id = 1, Nombre = "Admin", Email = "admin@demo.com", Clave = "1234", Rol = "Admin", Imagen = "img/admin.jpg" },
            new Usuario { Id = 2, Nombre = "Juan Pérez", Email = "juan@demo.com", Clave = "5678", Rol = "Empleado", Imagen = "img/empleado.jpg" }
        };

        public Task<List<Usuario>> ObtenerTodosAsync()
        {
            return Task.FromResult(usuarios);
        }

        public Task<Usuario?> ObtenerPorIdAsync(int id)
        {
            var usuario = usuarios.FirstOrDefault(u => u.Id == id);
            return Task.FromResult(usuario);
        }

        public Task AgregarAsync(Usuario usuario)
        {
            usuario.Id = usuarios.Any() ? usuarios.Max(u => u.Id) + 1 : 1;
            usuarios.Add(usuario);
            return Task.CompletedTask;
        }

        public Task EditarAsync(Usuario usuario)
        {
            var i = usuarios.FindIndex(u => u.Id == usuario.Id);
            if (i >= 0)
                usuarios[i] = usuario;

            return Task.CompletedTask;
        }

        public Task EliminarAsync(int id)
        {
            usuarios.RemoveAll(u => u.Id == id);
            return Task.CompletedTask;
        }

        public Task<Usuario?> ValidarLoginAsync(string email, string clave)
        {
            var usuario = usuarios.FirstOrDefault(u => u.Email == email && u.Clave == clave);
            return Task.FromResult(usuario);
        }
    }
}
