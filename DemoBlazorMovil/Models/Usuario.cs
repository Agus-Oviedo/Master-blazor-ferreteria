namespace DemoBlazorMovil.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Clave { get; set; }  // para login
        public string Rol { get; set; }    // "Admin", "Empleado", etc.
        public string Imagen { get; set; } // ruta relativa, ej: "img/admin.jpg"
    }
}
