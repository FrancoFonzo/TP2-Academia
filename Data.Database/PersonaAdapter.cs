using System;
using System.Collections.Generic;
using System.Linq;
using Business.Entities; 
using System.Text;
using System.Threading.Tasks;

namespace Data.Database
{
    public class PersonaAdapter : Adapter
    {
        public List<Persona> GetAll()
        {
            List<Persona> personas = new List<Persona>();
            using (AcademiaEntities db = new AcademiaEntities())
            {
                var lstPersonas = db.personas;

                foreach (var per in lstPersonas)
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
                        Tipo = (Persona.TiposPersonas) per.tipo_persona
                    };

                    personas.Add(persona);
                }
            }
            return personas;
        }

        public Persona GetOne(int ID)
        {
            Persona persona = new Persona();
            try
            {
                using (var db = new AcademiaEntities())
                {
                    //Si persona con ese id no existe?
                    var per = db.personas.Where(p => p.id_persona == ID).Single();
                    persona.ID = per.id_persona;
                    persona.Apellido = per.apellido;
                    persona.Nombre = per.nombre;
                    persona.EMail = per.email;
                    persona.FechaNacimiento = per.fecha_nac;
                    persona.Legajo = per.legajo;
                    persona.Direccion = per.direccion;
                    persona.Telefono = per.telefono;
                    persona.Tipo = (Persona.TiposPersonas)per.tipo_persona;
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocurrio un error al recuperar una persona");
            }
            return persona;
        }

        public void Delete(int ID)
        {
            using (var db = new AcademiaEntities())
            {
                var per = db.personas.Where(p => p.id_persona == ID);
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
                var per = db.personas.Where(p => p.id_persona == persona.ID).FirstOrDefault();
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
                personas per = new personas();
                per.id_persona = persona.ID;
                per.apellido = persona.Apellido;
                per.nombre = persona.Nombre;
                per.email = persona.EMail;
                per.fecha_nac = persona.FechaNacimiento;
                per.legajo = persona.Legajo;
                per.direccion = persona.Direccion;
                per.telefono = persona.Telefono;
                per.tipo_persona = (int)persona.Tipo;

                db.SaveChanges();
            }
        }
    }
}
