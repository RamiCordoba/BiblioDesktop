using BiblioDesktop.Interfaces;
using BiblioDesktop.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BiblioDesktop.AdminData
{
    class DbAdminTematicas : IDbAdmin
    {
        public void Actualizar(object tematica)
        {
            using BiblioDesktopContext db = new BiblioDesktopContext();
            db.Entry(tematica).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Agregar(object tematica)
        {
            using BiblioDesktopContext db = new BiblioDesktopContext();
            db.Tematicas.Add((Tematica)tematica);
            db.SaveChanges();
        }

        public void Eliminar(int idSeleccionado)
        {
            using BiblioDesktopContext db = new BiblioDesktopContext();
            var tematica = db.Tematicas.Find(idSeleccionado);

            tematica.Eliminado = true;
            tematica.FechaHoraEliminacion = DateTime.Now;
            tematica.Usuario = FrmMenuPrincipal.Usuario;
            db.Entry(tematica).State = EntityState.Modified;
            db.SaveChanges();

        }

        public object Obtener(int? idObtener)
        {
            //instanciamos un objeto DbContext
            using BiblioDesktopContext db = new BiblioDesktopContext();
            return db.Tematicas.Find(idObtener);
        }

        public IEnumerable<object> ObtenerEliminados()
        {
            using BiblioDesktopContext db = new BiblioDesktopContext();
            return db.Tematicas.Include(u => u.Usuario).IgnoreQueryFilters().Where(c => c.Eliminado == true).ToList();
        }

        public IEnumerable<object> ObtenerTodos()
        {
            using BiblioDesktopContext db = new BiblioDesktopContext();
            return db.Tematicas.Include(u => u.Usuario).IgnoreQueryFilters().Where(c => c.Eliminado == false).ToList();
        }

        public IEnumerable<object> ObtenerTodos(string cadenaBuscada)
        {
            //instanciamos nuestro objeto db Context
            using BiblioDesktopContext db = new BiblioDesktopContext();
            ////consultamos en la cadena buscada si contiene la expresion
            return db.Tematicas.Where(c => c.Nombre.Contains(cadenaBuscada)).Include(u => u.Usuario).IgnoreQueryFilters().Where(c => c.Eliminado == false).ToList().ToList();
        }

        public void Restaurar(int idSeleccionado)
        {
            using BiblioDesktopContext db = new BiblioDesktopContext();
            var tematica = db.Tematicas.IgnoreQueryFilters().FirstOrDefault(c => c.Id == idSeleccionado);
            tematica.Eliminado = false;
            db.Entry(tematica).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
