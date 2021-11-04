using System.Collections.Generic;
using System.Linq;
using Business.Entities;
using System.Data.Entity;
using System;

namespace Data.Database
{
    public class PersonaAdapter : Adapter
    {
        public List<Persona> GetAll()
        {
            try
            {
                using (AcademiaContext context = new AcademiaContext())
                {
                    return context.Persona.Include(p => p.Plan).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al recuperar las personas.", ex);
            }
        }

        public List<Persona> GetAllByTipo(Persona.TiposPersonas tipo)
        {
            try
            {
                using (var context = new AcademiaContext())
                {
                    return context.Persona.Include(p => p.Plan).Where(p => p.Tipo == tipo).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al recuperar las personas.", ex);
            }
        }

        public List<Persona> GetAllSinUsuario()
        {
            try
            {
                using (AcademiaContext context = new AcademiaContext())
                {
                    return context.Persona
                         .Include(p => p.Plan)
                         .Where(p =>
                             !context.Usuario
                             .Select(u => u.Persona)
                             .Contains(p))
                         .ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al recuperar las personas.", ex);
            }
        }

        public Persona GetOne(int id)
        {
            try
            {
                using (var context = new AcademiaContext())
                {
                    return context.Persona.Include(p => p.Plan).FirstOrDefault(p => p.ID == id);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al recuperar la persona.", ex);
            }

        }

        protected void Insert(Persona persona)
        {
            try
            {
                using (var context = new AcademiaContext())
                {
                    if (persona.Plan != null)
                    {
                        context.Plan.Attach(persona.Plan);
                    }
                    context.Persona.Add(persona);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar la persona.", ex);
            }
        }

        protected void Update(Persona persona)
        {
            try
            {
                using (var context = new AcademiaContext())
                {
                    context.Entry(persona).State = EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar la persona.", ex);
            }
        }

        public void Delete(Persona persona)
        {
            try
            {
                using (var context = new AcademiaContext())
                {
                    context.Persona.Remove(context.Persona.Find(persona.ID));
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar la persona.", ex);
            }
        }

        public void Save(Persona persona)
        {
            if (persona.State == BusinessEntity.States.New)
            {
                Insert(persona);
            }
            else if (persona.State == BusinessEntity.States.Modified)
            {
                Update(persona);
            }
            else if (persona.State == BusinessEntity.States.Deleted)
            {
                Delete(persona);
            }
            persona.State = BusinessEntity.States.Unmodified;
        }
    }
}
