using System.Collections.Generic;
using System.Linq;
using Business.Entities;
using System.Data.Entity;

namespace Data.Database
{
    public class PersonaAdapter : Adapter
    {
        public List<Persona> GetAll()
        {
            using (AcademiaContext context = new AcademiaContext())
            {
                return context.Persona.Include(p => p.Plan).ToList();
            }
        }

        public List<Persona> GetAllByTipo(Persona.TiposPersonas tipo)
        {
            using (var context = new AcademiaContext())
            {
                return context.Persona.Include(p => p.Plan).Where(p => p.Tipo == tipo).ToList();
            }
        }

        public List<Persona> GetAllSinUsuario()
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

        public Persona GetOne(int id)
        {
            using (var context = new AcademiaContext())
            {
                return context.Persona.Include(p => p.Plan).FirstOrDefault(p => p.ID == id);
            }

        }

        protected void Insert(Persona persona)
        {
            using (var context = new AcademiaContext())
            {
                if (persona.Plan != null) {
                    context.Plan.Attach(persona.Plan);
                }
                context.Persona.Add(persona);
                context.SaveChanges();
            }
        }

        protected void Update(Persona persona)
        {
            using (var context = new AcademiaContext())
            {
                context.Entry(persona).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(Persona persona)
        {
            using (var context = new AcademiaContext())
            {
                context.Persona.Remove(context.Persona.Find(persona.ID));
                context.SaveChanges();
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
