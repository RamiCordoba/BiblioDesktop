using BiblioDesktop.Interfaces;
using BiblioDesktop.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BiblioDesktop.AdminData
{
    class DbAdminUsuarios : IDbAdmin
    {
        public void Actualizar(object usuario)
        {
            using BiblioDesktopContext db = new BiblioDesktopContext();
            db.Entry(usuario).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Agregar(object usuario)
        {
            using BiblioDesktopContext db = new BiblioDesktopContext();
            db.Usuarios.Add((Usuario)usuario);
            db.SaveChanges();
        }

        public void Eliminar(int idSeleccionado)
        {
            using BiblioDesktopContext db = new BiblioDesktopContext();
            var usuario = db.Usuarios.Find(idSeleccionado);

            usuario.Eliminado = true;
            usuario.FechaHoraEliminacion = DateTime.Now;
            usuario.Usuario = FrmMenuPrincipal.Usuario;
            db.Entry(usuario).State = EntityState.Modified;
            db.SaveChanges();

        }

        public object Obtener(int? idObtener)
        {
            //instanciamos un objeto DbContext
            using BiblioDesktopContext db = new BiblioDesktopContext();
            return db.Usuarios.Find(idObtener);
        }

        public IEnumerable<object> ObtenerEliminados()
        {
            using BiblioDesktopContext db = new BiblioDesktopContext();
            return db.Usuarios.Include(u => u.Usuario).IgnoreQueryFilters().Where(c => c.Eliminado == true).ToList();
        }

        public IEnumerable<object> ObtenerTodos()
        {
            using BiblioDesktopContext db = new BiblioDesktopContext();
            return db.Usuarios.Include(u => u.Usuario).IgnoreQueryFilters().Where(c => c.Eliminado == false).ToList();
        }

        public IEnumerable<object> ObtenerTodos(string cadenaBuscada)
        {
            //instanciamos nuestro objeto db Context
            using BiblioDesktopContext db = new BiblioDesktopContext();
            ////consultamos en la cadena buscada si contiene la expresion
            return db.Usuarios.Where(c => c.Nombre.Contains(cadenaBuscada)).Include(u => u.Usuario).IgnoreQueryFilters().Where(c => c.Eliminado == false).ToList().ToList();
        }

        public void Restaurar(int idSeleccionado)
        {
            using BiblioDesktopContext db = new BiblioDesktopContext();
            var usuario = db.Usuarios.IgnoreQueryFilters().FirstOrDefault(c => c.Id == idSeleccionado);
            usuario.Eliminado = false;
            db.Entry(usuario).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
