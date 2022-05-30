using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using BiblioDesktop.Models;
using BiblioDesktop.Core;

namespace BiblioDesktop.Models
{
    public class BiblioDesktopContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Helper.ObtenerCadenaDeConexion());
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Datos Semilla Libros
            modelBuilder.Entity<Libro>().HasData(
                new Libro { Id = 1, Titulo = "Gaturro", Autor = "Nik", Editorial = "Ediciones de la Flor", TematicaId = 10},
                new Libro { Id = 2, Titulo = "Cien años de Soledad", Autor = "Gabriel García Marquez", Editorial = "Sudamericana", TematicaId = 12},
                new Libro { Id = 3, Titulo = "Virtual Hero", Autor = "El Rubius", Editorial = "Martínez Roca", TematicaId = 11 },
                new Libro { Id = 4, Titulo = "Condorito", Autor = "Pepo", Editorial = "Zig-Zag", TematicaId = 8 },
                new Libro { Id = 5, Titulo = "Entender el Cómic", Autor = "Scott McCloud", Editorial = "Tundra Publishing", TematicaId = 2 },
                new Libro { Id = 6, Titulo = "Lugares Asombrosos", Autor = "Luisito Comunica", Editorial = "Alfaguara Infantil Juvenil", TematicaId = 9 },
                new Libro { Id = 7, Titulo = "Martín Fierro", Autor = "José Hernandez", Editorial = "Imprenta de la Pampa", TematicaId = 4 },
                new Libro { Id = 8, Titulo = "La Voz del Gran Jefe", Autor = "Felipe Pigna", Editorial = "Booket", TematicaId = 14},
                new Libro { Id = 9, Titulo = "Mafalda", Autor = "Quino", Editorial = "El Mundo", TematicaId = 8 },
                new Libro { Id = 10, Titulo = "Los Juegos del Hambre", Autor = "Suzanne Collins", Editorial = "Scholastic Corporation", TematicaId = 1 });

            modelBuilder.Entity<Libro>()
                .HasOne(p => p.Tematica)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);
            #endregion
            #region Datos Semilla Socios
            modelBuilder.Entity<Socio>().HasData(
                new Socio { Id = 1, Apellido = "Córdoba", Nombre = "Facundo", Dni = 39541236, FechaNacimiento = new DateTime(1997, 5, 13), Domicilio = "20 de Junio 650", Telefono = 3498561561 },
                new Socio { Id = 2, Apellido = "Colombo", Nombre = "Juan Pablo", Dni = 35698741, FechaNacimiento = new DateTime(1995, 10, 8), Domicilio = "Independencia 2500", Telefono = 3425100321 },
                new Socio { Id = 3, Apellido = "Valle", Nombre = "Carlos Iván", Dni = 36541258, FechaNacimiento = new DateTime(1996, 12, 25), Domicilio = "9 de Julio 1550", Telefono = 3498123456 },
                new Socio { Id = 4, Apellido = "Sabino", Nombre = "Matías", Dni = 41236547, FechaNacimiento = new DateTime(2000, 2, 1), Domicilio = "25 de Mayo 2511", Telefono = 3498741258 },
                new Socio { Id = 5, Apellido = "Tibaldo", Nombre = "Agustín", Dni = 42856321, FechaNacimiento = new DateTime(2001, 2, 24), Domicilio = "Rivadavia 650", Telefono = 3498789456 });
            #endregion
            #region Datos Semilla Prestamos
            modelBuilder.Entity<Prestamo>().HasData(
                new Prestamo { Id = 1, FechaRetiro = new DateTime(2020, 5, 26), FechaEntrega = new DateTime(2020, 6, 26), SocioId = 1, IdLibro = 1, LibroDevuelto = false },
                new Prestamo { Id = 2, FechaRetiro = new DateTime(2020, 1, 10), FechaEntrega = new DateTime(2020, 11, 9), SocioId = 2, IdLibro = 2, LibroDevuelto = true },
                new Prestamo { Id = 3, FechaRetiro = new DateTime(2020, 12, 5), FechaEntrega = new DateTime(2020, 12, 12), SocioId = 3, IdLibro = 3, LibroDevuelto = false },
                new Prestamo { Id = 4, FechaRetiro = new DateTime(2020, 7, 17), FechaEntrega = new DateTime(2020, 12, 17), SocioId = 4, IdLibro = 4, LibroDevuelto = true },
                new Prestamo { Id = 5, FechaRetiro = new DateTime(2020, 1, 2), FechaEntrega = new DateTime(2020, 12, 31), SocioId = 5, IdLibro = 5, LibroDevuelto = false });
            #endregion
            #region Datos Semilla Tematicas
            modelBuilder.Entity<Tematica>().HasData(
                new Tematica { Id = 1, Nombre = "Ciencia Ficción" },
                new Tematica { Id = 2, Nombre = "Cómic y Manga" },
                new Tematica { Id = 3, Nombre = "Fantasía" },
                new Tematica { Id = 4, Nombre = "Poesía" },
                new Tematica { Id = 5, Nombre = "Teatro" },
                new Tematica { Id = 6, Nombre = "Cocina" },
                new Tematica { Id = 7, Nombre = "Autoayuda" },
                new Tematica { Id = 8, Nombre = "Humor" },
                new Tematica { Id = 9, Nombre = "Viajes" },
                new Tematica { Id = 10, Nombre = "Infantil" },
                new Tematica { Id = 11, Nombre = "Juvenil" },
                new Tematica { Id = 12, Nombre = "Literatura Contemporánea" },
                new Tematica { Id = 13, Nombre = "Arte" },
                new Tematica { Id = 14, Nombre = "Historia" },
                new Tematica { Id = 15, Nombre = "Filosofía" },
                new Tematica { Id = 16, Nombre = "Historieta" });
            #endregion
            #region Datos Semilla Usuarios
            modelBuilder.Entity<Usuario>().HasData(
                new Usuario { Id = 1, User = "admin", Password = "03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4", TipoUsuario = TipoUsuarioEnum.Administrador, Nombre = "admin" });
            #endregion
        }
        public DbSet<Libro> Libros { get; set; }
        public DbSet<Socio> Socios { get; set; }
        public DbSet<Prestamo> Prestamos { get; set; }
        public DbSet<Tematica> Tematicas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        public BiblioDesktopContext()
        {
        }
    }

}

