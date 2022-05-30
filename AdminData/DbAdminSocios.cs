using BiblioDesktop.Interfaces;
using BiblioDesktop.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BiblioDesktop.AdminData
{
    class DbAdminSocios : IDbAdmin
    {
        public void Actualizar(object socio)
        {
            using BiblioDesktopContext db = new BiblioDesktopContext();
            db.Entry(socio).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Agregar(object socio)
        {
            using BiblioDesktopContext db = new BiblioDesktopContext();
            db.Socios.Add((Socio)socio);
            db.SaveChanges();
        }

        public void Eliminar(int idSeleccionado)
        {
            using BiblioDesktopContext db = new BiblioDesktopContext();
            var socio = db.Socios.Find(idSeleccionado);

            socio.Eliminado = true;
            socio.FechaHoraEliminacion = DateTime.Now;
            socio.Usuario = FrmMenuPrincipal.Usuario;
            db.Entry(socio).State = EntityState.Modified;
            db.SaveChanges();

        }

        public object Obtener(int? idObtener)
        {
            //instanciamos un objeto DbContext
            using BiblioDesktopContext db = new BiblioDesktopContext();
            return db.Socios.Find(idObtener);
        }

        public IEnumerable<object> ObtenerEliminados()
        {
            using BiblioDesktopContext db = new BiblioDesktopContext();
            return db.Socios.Include(u => u.Usuario).IgnoreQueryFilters().Where(c => c.Eliminado == true).ToList();
        }

        public IEnumerable<object> ObtenerTodos()
        {
            using BiblioDesktopContext db = new BiblioDesktopContext();
            return db.Socios.Include(u => u.Usuario).IgnoreQueryFilters().Where(c => c.Eliminado == false).ToList();
        }

        public IEnumerable<object> ObtenerTodos(string cadenaBuscada)
        {
            //instanciamos nuestro objeto db Context
            using BiblioDesktopContext db = new BiblioDesktopContext();
            ////consultamos en la cadena buscada si contiene la expresion
            return db.Socios.Where(c => c.Nombre.Contains(cadenaBuscada)).Include(u => u.Usuario).IgnoreQueryFilters().Where(c => c.Eliminado == false).ToList().ToList();
        }

        public void Restaurar(int idSeleccionado)
        {
            using BiblioDesktopContext db = new BiblioDesktopContext();
            var socio = db.Socios.IgnoreQueryFilters().FirstOrDefault(c => c.Id == idSeleccionado);
            socio.Eliminado = false;
            db.Entry(socio).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
