using System.Collections.Generic;
using System.Linq;
using Business.Entities;

namespace Data.Database
{
    public class EspecialidadAdapter : Adapter
    {
        public List<Especialidad> GetAll()
        {
            using (AcademiaEntities db = new AcademiaEntities())
            {
                List<Especialidad> especialidades = new List<Especialidad>();
                var lstEspecialidades = db.especialidades;
                lstEspecialidades?.ToList().ForEach(e => especialidades.Add(nuevaEspecialidad(e)));
                return especialidades;
            }
        }

        private Especialidad nuevaEspecialidad(especialidades esp)
        {
            Especialidad especialidad = new Especialidad()
            {
                ID = esp.id_especialidad,
                DescEspecialidad = esp.desc_especialidad,
            };
            return especialidad;
        }


        public Especialidad GetOne(int ID)
        {
            using (var db = new AcademiaEntities())
            {
                var esp = db.especialidades.SingleOrDefault(e => e.id_especialidad == ID);
                if (esp == null) return null;
                return nuevaEspecialidad(esp);
            }

        }

        public void Delete(int ID)
        {
            using (var db = new AcademiaEntities())
            {
                var esp = db.especialidades.SingleOrDefault(p => p.id_especialidad == ID);
                if (esp == null) return;
                db.Entry(esp).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public void Save(Especialidad especialidad)
        {
            if (especialidad.State == BusinessEntity.States.Deleted)
            {
                this.Delete(especialidad.ID);
            }
            else if (especialidad.State == BusinessEntity.States.New)
            {
                this.Insert(especialidad);
            }
            else if (especialidad.State == BusinessEntity.States.Modified)
            {
                this.Update(especialidad);
            }
            especialidad.State = BusinessEntity.States.Unmodified;
        }

        protected void Update(Especialidad especialidad)
        {
            using (var db = new AcademiaEntities())
            {
                var esp = db.especialidades.SingleOrDefault(e => e.id_especialidad == especialidad.ID);
                if (esp == null) return;
                esp.desc_especialidad = especialidad.DescEspecialidad;
                db.SaveChanges();
            }
        }

        protected void Insert(Especialidad especialidad)
        {
            using (var db = new AcademiaEntities())
            {
                especialidades esp = new especialidades()
                {
                    id_especialidad = especialidad.ID
                };
                db.especialidades.Add(esp);
                db.SaveChanges();
            }
        }
    }

}
