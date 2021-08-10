using System.Collections.Generic;
using System.Linq;
using Business.Entities;

namespace Data.Database
{
    public class EspecialidadAdapter : Adapter
    {
        public List<Especialidad> GetAll()
        {
            using (AcademiaEntities context = new AcademiaEntities())
            {
                List<Especialidad> especialidades = new List<Especialidad>();
                var lstEspecialidades = context.especialidades;
                lstEspecialidades?.ToList().ForEach(e => especialidades.Add(nuevaEspecialidad(e)));
                return especialidades;
            }
        }

        private Especialidad nuevaEspecialidad(especialidades esp)
        {
            if (esp == null)
            {
                return null;
            }
            Especialidad especialidad = new Especialidad
            {
                ID = esp.id_especialidad,
                Descripcion = esp.desc_especialidad,
            };
            return especialidad;
        }


        public Especialidad GetOne(int ID)
        {
            using (var context = new AcademiaEntities())
            {
                var esp = context.especialidades.SingleOrDefault(e => e.id_especialidad == ID);
                return nuevaEspecialidad(esp);
            }
        }

        public void Delete(int ID)
        {
            using (var context = new AcademiaEntities())
            {
                var esp = context.especialidades.SingleOrDefault(p => p.id_especialidad == ID);
                if (esp != null)
                {
                    context.Entry(esp).State = System.Data.Entity.EntityState.Deleted;
                    context.SaveChanges();
                }
            }
        }

        public void Save(Especialidad especialidad)
        {
            if (especialidad.State == BusinessEntity.States.Deleted)
            {
                Delete(especialidad.ID);
            }
            else if (especialidad.State == BusinessEntity.States.New)
            {
                Insert(especialidad);
            }
            else if (especialidad.State == BusinessEntity.States.Modified)
            {
                Update(especialidad);
            }
            especialidad.State = BusinessEntity.States.Unmodified;
        }

        protected void Update(Especialidad especialidad)
        {
            using (var context = new AcademiaEntities())
            {
                var esp = context.especialidades.SingleOrDefault(e => e.id_especialidad == especialidad.ID);
                if (esp != null)
                {
                    esp.desc_especialidad = especialidad.Descripcion;
                    context.SaveChanges();
                }
            }
        }

        protected void Insert(Especialidad especialidad)
        {
            using (var context = new AcademiaEntities())
            {
                especialidades esp = new especialidades
                {
                    id_especialidad = especialidad.ID,
                    desc_especialidad = especialidad.Descripcion
                };
                context.especialidades.Add(esp);
                context.SaveChanges();
            }
        }
    }

}
