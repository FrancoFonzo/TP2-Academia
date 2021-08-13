using System.Collections.Generic;
using System.Linq;
using Business.Entities;

namespace Data.Database
{
    public class PersonaAdapter : Adapter
    {
        public List<Persona> GetAll()
        {
            using (AcademiaEntities context = new AcademiaEntities())
            {
                List<Persona> personas = new List<Persona>();
                context.personas
                    .ToList()
                    .ForEach(p => personas.Add(NuevaPersona(p)));
                return personas;
            }
        }

        public List<Persona> GetAllTipo(Persona.TiposPersonas tipo)
        {
            using (var context = new AcademiaEntities())
            {
                List<Persona> personas = new List<Persona>();
                context.personas
                    .Where(p => p.tipo_persona == (int)tipo)
                    .ToList()
                    .ForEach(p => personas.Add(NuevaPersona(p)));
                return personas;
            }
        }

        public List<Persona> GetPersonasSinUsuario()
        {
            using (AcademiaEntities context = new AcademiaEntities())
            {
                List<Persona> personas = new List<Persona>();
                context.personas
                    .Where(p =>
                        !context.usuarios
                        .Select(u => u.id_persona)
                        .Contains(p.id_persona))
                    .ToList()
                    .ForEach(p => personas.Add(NuevaPersona(p)));
                return personas;
            }
        }

        public Persona GetOne(int id)
        {
            using (var context = new AcademiaEntities())
            {
                var per = context.personas.FirstOrDefault(p => p.id_persona == id);
                return NuevaPersona(per);
            }

        }

        public void Delete(int id)
        {
            using (var context = new AcademiaEntities())
            {
                var per = context.personas.FirstOrDefault(p => p.id_persona == id);
                if (per != null)
                {
                    context.Entry(per).State = System.Data.Entity.EntityState.Deleted;
                    context.SaveChanges();
                }
            }
        }

        public void Save(Persona persona)
        {
            if (persona.State == BusinessEntity.States.Deleted)
            {
                Delete(persona.ID);
            }
            else if (persona.State == BusinessEntity.States.New)
            {
                Insert(persona);
            }
            else if (persona.State == BusinessEntity.States.Modified)
            {
                Update(persona);
            }
            persona.State = BusinessEntity.States.Unmodified;
        }

        protected void Update(Persona persona)
        {
            using (var context = new AcademiaEntities())
            {
                var per = context.personas.FirstOrDefault(p => p.id_persona == persona.ID);
                if (per != null)
                {
                    per.apellido = persona.Apellido;
                    per.nombre = persona.Nombre;
                    per.email = persona.EMail;
                    per.fecha_nac = persona.FechaNacimiento;
                    per.legajo = persona.Legajo;
                    per.direccion = persona.Direccion;
                    per.telefono = persona.Telefono;
                    per.tipo_persona = (int)persona.Tipo;
                    per.id_plan = persona.MiPlan?.ID;
                    context.SaveChanges();
                }
            }
        }

        protected void Insert(Persona persona)
        {
            using (var context = new AcademiaEntities())
            {
                personas per = new personas
                {
                    id_persona = persona.ID,
                    apellido = persona.Apellido,
                    nombre = persona.Nombre,
                    email = persona.EMail,
                    fecha_nac = persona.FechaNacimiento,
                    legajo = persona.Legajo,
                    direccion = persona.Direccion,
                    telefono = persona.Telefono,
                    tipo_persona = (int)persona.Tipo,
                    id_plan = persona.MiPlan?.ID
                };
                context.personas.Add(per);
                context.SaveChanges();
            }
        }

        private Persona NuevaPersona(personas per)
        {
            if (per == null)
            {
                return null;
            }
            Persona persona = new Persona
            {
                ID = per.id_persona,
                Apellido = per.apellido,
                Nombre = per.nombre,
                EMail = per.email,
                FechaNacimiento = per.fecha_nac,
                Legajo = per.legajo,
                Direccion = per.direccion,
                Telefono = per.telefono,
                Tipo = (Persona.TiposPersonas)per.tipo_persona
            };
            if (per.id_plan != null)
            {
                persona.MiPlan = planData.GetOne((int)per.id_plan);
            }
            return persona;
        }
    }
}
