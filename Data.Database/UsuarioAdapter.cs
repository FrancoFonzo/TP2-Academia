using System;
using System.Collections.Generic;
using System.Text;
using Business.Entities;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Data.Database
{
    public class UsuarioAdapter
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
                        ID_Persona = user.id_persona
                    };
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
                var usr = db.usuarios.Where(u => u.id_usuario == ID).FirstOrDefault();
                usuario.ID = usr.id_usuario;
                usuario.NombreUsuario = usr.nombre_usuario;
                usuario.Clave = usr.clave;
                usuario.Habilitado = usr.habilitado;
                usuario.ID_Persona = usr.id_persona;
            }
            return usuario;
        }

        public void Delete(int ID)
        {
            using (var db = new AcademiaEntities())
            {
                var usr = db.usuarios.Where(u => u.id_usuario == ID);
                db.Entry(usr).State = System.Data.Entity.EntityState.Deleted;
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
                var usr = db.usuarios.Where(u => u.id_usuario == usuario.ID).FirstOrDefault();
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
                usr.id_persona = usuario.ID_Persona;

                db.SaveChanges();
            }
        }
    }
}
