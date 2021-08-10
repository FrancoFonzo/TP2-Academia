using System.Collections.Generic;
using Business.Entities;
using System.Linq;

namespace Data.Database
{
    public class UsuarioAdapter : Adapter
    {
        public List<Usuario> GetAll()
        {
            using (AcademiaEntities context = new AcademiaEntities())
            {
                List<Usuario> usuarios = new List<Usuario>();
                var lstUsuarios = context.usuarios;
                lstUsuarios?.ToList().ForEach(u => usuarios.Add(nuevoUsuario(u)));
                return usuarios;
            }
        }

        private static Usuario nuevoUsuario(usuarios user)
        {
            if (user == null)
            {
                return null;
            }
            Usuario usuario = new Usuario
            {
                ID = user.id_usuario,
                NombreUsuario = user.nombre_usuario,
                Clave = user.clave,
                Habilitado = user.habilitado,
            };
            if (user.id_persona != null)
            {
                usuario.MiPersona = personaData.GetOne((int)user.id_persona);
            }
            return usuario;
        }

        public Usuario GetOne(int ID)
        {
            using (var context = new AcademiaEntities())
            {
                var usr = context.usuarios.SingleOrDefault(u => u.id_usuario == ID);
                return nuevoUsuario(usr);
            }
        }

        public Usuario GetOneNombreUsuario(string nom_usuario)
        {
            using (var context = new AcademiaEntities())
            {
                var usr = context.usuarios.SingleOrDefault(u => u.nombre_usuario == nom_usuario);
                return nuevoUsuario(usr);
            }
        }

        public void Delete(int ID)
        {
            using (var context = new AcademiaEntities())
            {
                var usr = context.usuarios.SingleOrDefault(u => u.id_usuario == ID);
                if (usr != null)
                {
                    context.usuarios.Remove(usr);
                    context.SaveChanges();
                }
            }
        }

        public void Save(Usuario usuario)
        {
            if (usuario.State == BusinessEntity.States.Deleted)
            {
                Delete(usuario.ID);
            }
            else if (usuario.State == BusinessEntity.States.New)
            {
                Insert(usuario);
            }
            else if (usuario.State == BusinessEntity.States.Modified)
            {
                Update(usuario);
            }
            usuario.State = BusinessEntity.States.Unmodified;
        }

        protected void Update(Usuario usuario)
        {
            using (var context = new AcademiaEntities())
            {
                var usr = context.usuarios.SingleOrDefault(u => u.id_usuario == usuario.ID);
                if (usr != null)
                {
                    usr.nombre_usuario = usuario.NombreUsuario;
                    usr.clave = usuario.Clave;
                    usr.habilitado = usuario.Habilitado;
                    usr.id_persona = usuario.MiPersona?.ID;
                    context.SaveChanges();
                }
            }
        }

        protected void Insert(Usuario usuario)
        {
            using (var context = new AcademiaEntities())
            {
                usuarios usr = new usuarios
                {
                    id_usuario = usuario.ID,
                    nombre_usuario = usuario.NombreUsuario,
                    clave = usuario.Clave,
                    habilitado = usuario.Habilitado
                };
                if (usuario.MiPersona != null)
                {
                    usr.id_persona = usuario.MiPersona.ID;
                }
                context.usuarios.Add(usr);
                context.SaveChanges();
            }
        }
    }
}
