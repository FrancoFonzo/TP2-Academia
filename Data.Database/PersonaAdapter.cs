using System.Collections.Generic;
using System.Linq;
using Business.Entities;

namespace Data.Database
{
    public class PersonaAdapter : Adapter
    {
        public List<Persona> GetAll()
        {
            using (AcademiaEntities db = new AcademiaEntities())
            {
                List<Persona> personas = new List<Persona>();
                var lstPersonas = db.personas;
                lstPersonas?.ToList().ForEach(p => personas.Add(nuevaPersona(p)));
                return personas;
            }   
        }

        private Persona nuevaPersona(personas per)
        {
            Persona persona = new Persona()
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
            return persona;
        }

        public List<Persona> GetPersonasSinUsuario()
        {
            using (AcademiaEntities db = new AcademiaEntities())
            {
                List<Persona> personas = new List<Persona>();
                var lstPersonas = from p in db.personas 
                                  where !(from u in db.usuarios select u.id_persona)
                                  .Contains(p.id_persona) select p;
                //db.personas.Where(p => !db.usuarios.Select(u=> u.id_persona).Contains(p.id_persona));
                lstPersonas?.ToList().ForEach(p => personas.Add(nuevaPersona(p)));
                return personas;
            }
        }

        public Persona GetOne(int ID)
        {
            using (var db = new AcademiaEntities())
            {
                var per = db.personas.SingleOrDefault(p => p.id_persona == ID);
                if (per == null) return null;
                return nuevaPersona(per);
            }
            
        }

        public void Delete(int ID)
        {
            using (var db = new AcademiaEntities())
            {
                var per = db.personas.SingleOrDefault(p => p.id_persona == ID);
                if (per == null) return;
                db.Entry(per).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public void Save(Persona persona)
        {
            if (persona.State == BusinessEntity.States.Deleted)
            {
                this.Delete(persona.ID);
            }
            else if (persona.State == BusinessEntity.States.New)
            {
                this.Insert(persona);
            }
            else if (persona.State == BusinessEntity.States.Modified)
            {
                this.Update(persona);
            }
            persona.State = BusinessEntity.States.Unmodified;
        }

        protected void Update(Persona persona)
        {
            using (var db = new AcademiaEntities())
            {
                var per = db.personas.SingleOrDefault(p => p.id_persona == persona.ID);
                if (per == null) return;
                per.apellido = persona.Apellido;
                per.nombre = persona.Nombre; 
                per.email = persona.EMail;
                per.fecha_nac = persona.FechaNacimiento;
                per.legajo = persona.Legajo;
                per.direccion = persona.Direccion;
                per.telefono = persona.Telefono;
                per.tipo_persona = (int) persona.Tipo;

                db.SaveChanges();
            }
        }

        protected void Insert(Persona persona)
        {
            using (var db = new AcademiaEntities())
            {
                personas per = new personas()
                {
                    id_persona = persona.ID,
                    apellido = persona.Apellido,
                    nombre = persona.Nombre,
                    email = persona.EMail,
                    fecha_nac = persona.FechaNacimiento,
                    legajo = persona.Legajo,
                    direccion = persona.Direccion,
                    telefono = persona.Telefono,
                    tipo_persona = (int)persona.Tipo
                };
                db.personas.Add(per);
                db.SaveChanges();
            }
        }
    }
}
