using System.Collections.Generic;
using System.Linq;
using Business.Entities;
using System.Data.Entity;

namespace Data.Database
{
    public class EspecialidadAdapter : Adapter
    {
        public List<Especialidad> GetAll()
        {
            using (AcademiaContext context = new AcademiaContext())
            {
                return context.Especialidad.ToList();
            }
        }

        public Especialidad GetOne(int id)
        {
            using (var context = new AcademiaContext())
            {
                return context.Especialidad.Find(id);
            }
        }

        protected void Insert(Especialidad especialidad)
        {
            using (var context = new AcademiaContext())
            {
                context.Especialidad.Add(especialidad);
                context.SaveChanges();
            }
        }

        protected void Update(Especialidad especialidad)
        {
            using (var context = new AcademiaContext())
            {
                context.Entry(especialidad).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(Especialidad especialidad)
        {
            using (var context = new AcademiaContext())
            {
                context.Especialidad.Remove(context.Especialidad.Find(especialidad.ID));
                context.SaveChanges();
            }
        }

        public void Save(Especialidad especialidad)
        {
            if (especialidad.State == BusinessEntity.States.New)
            {
                Insert(especialidad);
            }
            else if (especialidad.State == BusinessEntity.States.Modified)
            {
                Update(especialidad);
            }
            else if (especialidad.State == BusinessEntity.States.Deleted)
            {
                Delete(especialidad);
            }
            especialidad.State = BusinessEntity.States.Unmodified;
        }
    }
}
