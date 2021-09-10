using System.Collections.Generic;
using System.Linq;
using Business.Entities;
using System.Data.Entity;

namespace Data.Database
{
    public class MateriaAdapter : Adapter
    {
        public List<Materia> GetAll()
        {
            using (AcademiaContext context = new AcademiaContext())
            {
                return context.Materia.Include(m => m.Plan).ToList();
            }
        }

        public Materia GetOne(int id)
        {
            using (var context = new AcademiaContext())
            {
                return context.Materia.Include(m => m.Plan).FirstOrDefault(m => m.ID == id);
            }
        }

        protected void Insert(Materia materia)
        {
            using (var context = new AcademiaContext())
            {
                context.Plan.Attach(materia.Plan);
                context.Materia.Add(materia);
                context.SaveChanges();
            }
        }

        protected void Update(Materia materia)
        {
            using (var context = new AcademiaContext())
            {
                context.Entry(materia).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(Materia materia)
        {
            using (var context = new AcademiaContext())
            {
                context.Materia.Remove(context.Materia.Find(materia.ID));
                context.SaveChanges();
            }
        }

        public void Save(Materia materia)
        {
            if (materia.State == BusinessEntity.States.New)
            {
                Insert(materia);
            }
            else if (materia.State == BusinessEntity.States.Modified)
            {
                Update(materia);
            }
            else if (materia.State == BusinessEntity.States.Deleted)
            {
                Delete(materia);
            }
            materia.State = BusinessEntity.States.Unmodified;
        }
    }
}
