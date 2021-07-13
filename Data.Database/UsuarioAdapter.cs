using System;
using System.Collections.Generic;
using System.Text;
using Business.Entities;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Data.Database
{
    public class UsuarioAdapter : Adapter
    {
        public List<Usuario> GetAll()
        {
            List<Usuario> usuarios = new List<Usuario>();
            using (AcademiaEntities db = new AcademiaEntities())
            {
                var lstUsuarios = db.usuarios;

                foreach (var user in lstUsuarios)
                {
                    Usuario usuario = new Usuario()
                    {
                        ID = user.id_usuario,
                        NombreUsuario = user.nombre_usuario,
                        Clave = user.clave,
                        Habilitado = user.habilitado,
                    };
                    if (user.id_persona != null) usuario.MiPersona = personaData.GetOne((int)user.id_persona);
                    usuarios.Add(usuario);
                }
            }
            return usuarios;
        }

        public Usuario GetOne(int ID)
        {
            Usuario usuario = new Usuario();
            using (var db = new AcademiaEntities())
            {
                var usr = db.usuarios.SingleOrDefault(u => u.id_usuario == ID);
                if (usr == null) return null;
                usuario.ID = usr.id_usuario;
                usuario.NombreUsuario = usr.nombre_usuario;
                usuario.Clave = usr.clave;
                usuario.Habilitado = usr.habilitado;
                if (usr.id_persona != null) usuario.MiPersona = personaData.GetOne((int)usr.id_persona);
            }
            return usuario;
        }

        public Usuario GetOneNombreUsuario(string nom_usuario)
        {
            Usuario usuario = new Usuario();
            using (var db = new AcademiaEntities())
            {
                var usr = db.usuarios.SingleOrDefault(u => u.nombre_usuario == nom_usuario);
                if (usr == null) return null;
                usuario.ID = usr.id_usuario;
                usuario.NombreUsuario = usr.nombre_usuario;
                usuario.Clave = usr.clave;
                usuario.Habilitado = usr.habilitado;
                if (usr.id_persona != null) usuario.MiPersona = personaData.GetOne((int)usr.id_persona);
            }
            return usuario;
        }

        public void Delete(int ID)
        {
            using (var db = new AcademiaEntities())
            {
                var usr = db.usuarios.SingleOrDefault(u => u.id_usuario == ID);
                if (usr == null) return;
                db.usuarios.Remove(usr);
                db.SaveChanges();
            }
        }

        public void Save(Usuario usuario)
        {
            if (usuario.State == BusinessEntity.States.Deleted)
            {
                this.Delete(usuario.ID);
            }
            else if (usuario.State == BusinessEntity.States.New)
            {
                this.Insert(usuario);
            }
            else if (usuario.State == BusinessEntity.States.Modified)
            {
                this.Update(usuario);
            }
            usuario.State = BusinessEntity.States.Unmodified;
        }

        protected void Update(Usuario usuario)
        {
            using (var db = new AcademiaEntities())
            {
                var usr = db.usuarios.SingleOrDefault(u => u.id_usuario == usuario.ID);
                if (usr == null) return;
                usr.nombre_usuario = usuario.NombreUsuario;
                usr.clave = usuario.Clave;
                usr.habilitado = usuario.Habilitado;
                
                db.SaveChanges();
            }
        }

        protected void Insert(Usuario usuario)
        {
            using (var db = new AcademiaEntities())
            {
                usuarios usr = new usuarios();
                usr.id_usuario = usuario.ID;
                usr.nombre_usuario = usuario.NombreUsuario;
                usr.clave = usuario.Clave;
                usr.habilitado = usuario.Habilitado;
                if (usuario.MiPersona != null) usr.id_persona = usuario.MiPersona.ID;
                
                db.usuarios.Add(usr);
                db.SaveChanges();
            }
        }
    }
}
