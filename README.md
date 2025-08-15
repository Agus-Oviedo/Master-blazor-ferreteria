# 🛠️ DemoBlazorMovil - Ferretería

Aplicación de gestión de ferretería desarrollada con **Blazor Hybrid (.NET MAUI)**. Permite realizar operaciones de ABM (alta, baja, modificación) sobre **usuarios** y **productos**, con control de acceso por rol y diseño responsive usando **Bootstrap 5**.

---

## 🚀 Funcionalidades

### 🔐 Login de usuarios
- Validación por email y clave.
- Sesión persistida en memoria (`SesionUsuario`).
- Redirección automática según rol.
- Cierre de sesión con botón dedicado.

### 👥 Gestión de Usuarios (solo Admin)
- ABM completo de usuarios.
- Visualización en tabla con imágenes locales.
- Accesible solo para usuarios con rol `Admin`.

### 📦 Gestión de Productos
- Visualización para todos los usuarios logueados.
- ABM completo solo para `Admin`, modo lectura para `Empleado`.
- Imágenes locales.
- UI con tabla y botones de acción.

### 📋 Control de acceso por rol
- Menú dinámico (`NavMenu.razor`) con íconos Bootstrap.
- Acceso a páginas restringido según el rol.
- Componente `SesionUsuario` centralizado para estado de login.

---

## 🧰 Tecnologías utilizadas

- .NET 8 / Blazor Hybrid (.NET MAUI)
- C#
- Bootstrap 5 + Bootstrap Icons
- Blazor Components
- Arquitectura por capas: `Services`, `Models`, `Pages`, `Components`

---

## 📂 Estructura del proyecto

```
DemoBlazorMovil/
│
├── Models/               → Clases de dominio: Usuario, Producto
├── Services/             → Servicios de lógica: UsuarioService, ProductoService, SesionUsuario
├── Pages/                → Vistas (razor): Login, Productos, Usuarios
├── Components/Layout/    → MainLayout, NavMenu
├── Resources/img/        → Imágenes de usuarios y productos
├── MauiProgram.cs        → Configuración y DI
└── MainPage.razor        → Entrada de la app
```

---

## 🏁 Cómo ejecutar el proyecto

1. Abrir el archivo `DemoBlazorMovil.sln` con **Visual Studio 2022+**.
2. Seleccionar una plataforma de destino (Windows, Android, etc.).
3. Ejecutar el proyecto (`Ctrl + F5`).

---

## 👥 Usuarios de prueba para iniciar sesión

Usá estas credenciales para probar el sistema:

| Rol      | Nombre       | Email             | Contraseña |
|----------|--------------|-------------------|------------|
| Admin    | Admin        | admin@demo.com    | 1234       |
| Empleado | Juan Pérez   | juan@demo.com     | 5678       |

---

## 📸 Capturas de pantalla

¡Incluí capturas del login, lista de productos y usuarios para mostrar la UI!

---

## 📌 Autor

Proyecto desarrollado como parte de una práctica de Blazor Hybrid – Ferretería.