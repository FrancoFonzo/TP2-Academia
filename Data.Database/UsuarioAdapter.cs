using System.Collections.Generic;
using Business.Entities;
using System.Linq;
using System.Data.Entity;

namespace Data.Database
{
    public class UsuarioAdapter : Adapter
    {
        public List<Usuario> GetAll()
        {
            using (AcademiaContext context = new AcademiaContext())
            {
                return context.Usuario.Include(u => u.Persona).ToList();
            }
        }

        public Usuario GetOne(int id)
        {
            using (var context = new AcademiaContext())
            {
                return context.Usuario.Include(u => u.Persona).FirstOrDefault(u => u.ID == id);
            }
        }

        public Usuario GetOneByNombreUsuario(string nombreUsuario)
        {
            using (var context = new AcademiaContext())
            {
                return context.Usuario.Include(u => u.Persona).FirstOrDefault(u => u.NombreUsuario == nombreUsuario);
            }
        }

        protected void Insert(Usuario usuario)
        {
            using (var context = new AcademiaContext())
            {
                context.Persona.Attach(usuario.Persona);
                context.Usuario.Add(usuario);
                context.SaveChanges();
            }
        }

        protected void Update(Usuario usuario)
        {
            using (var context = new AcademiaContext())
            {
                context.Entry(usuario).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(Usuario usuario)
        {
            using (var context = new AcademiaContext())
            {
                context.Usuario.Remove(context.Usuario.Find(usuario.ID));
                context.SaveChanges();
            }
        }

        public void Save(Usuario usuario)
        {
            if (usuario.State == BusinessEntity.States.New)
            {
                Insert(usuario);
            }
            else if (usuario.State == BusinessEntity.States.Modified)
            {
                Update(usuario);
            }
            else if (usuario.State == BusinessEntity.States.Deleted)
            {
                Delete(usuario);
            }
            usuario.State = BusinessEntity.States.Unmodified;
        }
    }
}
