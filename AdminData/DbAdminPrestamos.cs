using BiblioDesktop.Interfaces;
using BiblioDesktop.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BiblioDesktop.AdminData
{
    class DbAdminPrestamos : IDbAdmin
    {
        public void Actualizar(object prestamo)
        {
            using BiblioDesktopContext db = new BiblioDesktopContext();
            db.Entry(prestamo).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Agregar(object prestamo)
        {
            using BiblioDesktopContext db = new BiblioDesktopContext();
            db.Prestamos.Add((Prestamo)prestamo);
            db.SaveChanges();
        }

        public void Eliminar(int idSeleccionado)
        {
            using BiblioDesktopContext db = new BiblioDesktopContext();
            var prestamo = db.Prestamos.Find(idSeleccionado);

            prestamo.Eliminado = true;
            prestamo.FechaHoraEliminacion = DateTime.Now;
            prestamo.Usuario = FrmMenuPrincipal.Usuario;
            db.Entry(prestamo).State = EntityState.Modified;
            db.SaveChanges();

        }

        public object Obtener(int? idObtener)
        {
            //instanciamos un objeto DbContext
            using BiblioDesktopContext db = new BiblioDesktopContext();
            return db.Prestamos.Find(idObtener);
        }

        public IEnumerable<object> ObtenerEliminados()
        {
            using BiblioDesktopContext db = new BiblioDesktopContext();
            return db.Prestamos.Include(u => u.Usuario).IgnoreQueryFilters().Where(c => c.Eliminado == true).ToList();
        }

        public IEnumerable<object> ObtenerTodos()
        {
            using BiblioDesktopContext db = new BiblioDesktopContext();
            return db.Prestamos.Include(u => u.Usuario).IgnoreQueryFilters().Where(c => c.Eliminado == false).ToList();
        }

        public IEnumerable<object> ObtenerTodos(string cadenaBuscada)
        {
            //instanciamos nuestro objeto db Context
            using BiblioDesktopContext db = new BiblioDesktopContext();
            ////consultamos en la cadena buscada si contiene la expresion
            return db.Prestamos.Where(c => c.Socio.Nombre.Contains(cadenaBuscada)).Include(u => u.Usuario).IgnoreQueryFilters().Where(c => c.Eliminado == false).ToList().ToList();
        }

        public void Restaurar(int idSeleccionado)
        {
            using BiblioDesktopContext db = new BiblioDesktopContext();
            var prestamo = db.Prestamos.IgnoreQueryFilters().FirstOrDefault(c => c.Id == idSeleccionado);
            prestamo.Eliminado = false;
            db.Entry(prestamo).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
