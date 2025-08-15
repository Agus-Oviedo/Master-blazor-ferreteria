using DemoBlazorMovil.Models;

namespace DemoBlazorMovil.Services
{
    public class SesionUsuario
    {
        public Usuario? UsuarioActual { get; private set; }

        public bool EstaLogueado => UsuarioActual != null;

        // Evento que se dispara cuando cambia el estado de la sesión
        public event Action? OnCambioSesion;

        public void IniciarSesion(Usuario usuario)
        {
            UsuarioActual = usuario;
            OnCambioSesion?.Invoke();
        }

        public void CerrarSesion()
        {
            UsuarioActual = null;
            OnCambioSesion?.Invoke();
        }
    }
}
