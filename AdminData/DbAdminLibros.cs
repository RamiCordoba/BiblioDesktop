using BiblioDesktop.Interfaces;
using BiblioDesktop.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BiblioDesktop.AdminData
{
    class DbAdminLibros : IDbAdmin
    {
        public void Actualizar(object libro)
        {
            using BiblioDesktopContext db = new BiblioDesktopContext();
            db.Entry(libro).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Agregar(object libro)
        {
            using BiblioDesktopContext db = new BiblioDesktopContext();
            db.Libros.Add((Libro)libro);
            db.SaveChanges();
        }

        public void Eliminar(int idSeleccionado)
        {
            using BiblioDesktopContext db = new BiblioDesktopContext();
            var libro = db.Libros.Find(idSeleccionado);

            libro.Eliminado = true;
            libro.FechaHoraEliminacion = DateTime.Now;
            libro.Usuario = FrmMenuPrincipal.Usuario;
            db.Entry(libro).State = EntityState.Modified;
            db.SaveChanges();

        }

        public object Obtener(int? idObtener)
        {
            //instanciamos un objeto DbContext
            using BiblioDesktopContext db = new BiblioDesktopContext();
            return db.Libros.Find(idObtener);
        }

        public IEnumerable<object> ObtenerEliminados()
        {
            using BiblioDesktopContext db = new BiblioDesktopContext();
            return db.Libros.Include(u => u.Usuario).IgnoreQueryFilters().Where(c => c.Eliminado == true).ToList();
        }

        public IEnumerable<object> ObtenerTodos()
        {
            using BiblioDesktopContext db = new BiblioDesktopContext();
            return db.Libros.Include(u => u.Usuario).IgnoreQueryFilters().Where(c => c.Eliminado == false).ToList();
        }

        public IEnumerable<object> ObtenerTodos(string cadenaBuscada)
        {
            //instanciamos nuestro objeto db Context
            using BiblioDesktopContext db = new BiblioDesktopContext();
            ////consultamos en la cadena buscada si contiene la expresion
            return db.Libros.Where(c => c.Titulo.Contains(cadenaBuscada)).Include(u => u.Usuario).IgnoreQueryFilters().Where(c => c.Eliminado == false).ToList().ToList();
        }

        public void Restaurar(int idSeleccionado)
        {
            using BiblioDesktopContext db = new BiblioDesktopContext();
            var libro = db.Libros.IgnoreQueryFilters().FirstOrDefault(c => c.Id == idSeleccionado);
            libro.Eliminado = false;
            db.Entry(libro).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
