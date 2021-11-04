using System.Collections.Generic;
using Business.Entities;
using System.Linq;
using System.Data.Entity;
using System;

namespace Data.Database
{
    public class UsuarioAdapter : Adapter
    {
        public List<Usuario> GetAll()
        {
            try
            {
                using (AcademiaContext context = new AcademiaContext())
                {
                    return context.Usuario.Include(u => u.Persona).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al recuperar los usuarios.", ex);
            }
        }

        public Usuario GetOne(int id)
        {
            try
            {
                using (var context = new AcademiaContext())
                {
                    return context.Usuario.Include(u => u.Persona).FirstOrDefault(u => u.ID == id);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al recuperar el usuario: /nMensaje.", ex);
            }
        }

        public Usuario GetOneByNombreUsuario(string nombreUsuario)
        {
            try
            {
                using (var context = new AcademiaContext())
                {
                    return context.Usuario.Include(u => u.Persona).FirstOrDefault(u => u.NombreUsuario == nombreUsuario);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al recuperar el usuario.", ex);
            }
        }

        protected void Insert(Usuario usuario)
        {
            try
            {
                using (var context = new AcademiaContext())
                {
                    if (usuario.Persona != null)
                    {
                        context.Persona.Attach(usuario.Persona);
                    }
                    context.Usuario.Add(usuario);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar el usuario.", ex);
            }
        }

        protected void Update(Usuario usuario)
        {
            try
            {
                using (var context = new AcademiaContext())
                {
                    context.Entry(usuario).State = EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar el usuario.", ex);
            }
        }

        public void Delete(Usuario usuario)
        {
            try
            {
                using (var context = new AcademiaContext())
                {
                    context.Usuario.Remove(context.Usuario.Find(usuario.ID));
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el usuario.", ex);
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
