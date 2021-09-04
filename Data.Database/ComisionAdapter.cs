using System.Collections.Generic;
using System.Linq;
using Business.Entities;
using System.Data.Entity;

namespace Data.Database
{
    public class ComisionAdapter : Adapter
    {
        public List<Comision> GetAll()
        {
            using (AcademiaContext context = new AcademiaContext())
            {
                return context.Comision.Include(c => c.Plan).ToList();
            }
        }

        public Comision GetOne(int id)
        {
            using (var context = new AcademiaContext())
            {
                return context.Comision.Include(c => c.Plan).FirstOrDefault(c => c.ID == id);
            }
        }

        protected void Insert(Comision comision)
        {
            using (var context = new AcademiaContext())
            {
                context.Plan.Attach(comision.Plan);
                context.Comision.Add(comision);
                context.SaveChanges();
            }
        }

        protected void Update(Comision comision)
        {
            using (var context = new AcademiaContext())
            {
                context.Entry(comision).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(Comision comision)
        {
            using (var context = new AcademiaContext())
            {
                context.Comision.Remove(context.Comision.Find(comision.ID));
                context.SaveChanges();
            }
        }

        public void Save(Comision comision)
        {
            if (comision.State == BusinessEntity.States.New)
            {
                Insert(comision);
            }
            else if (comision.State == BusinessEntity.States.Modified)
            {
                Update(comision);
            }
            else if (comision.State == BusinessEntity.States.Deleted)
            {
                Delete(comision);
            }
            comision.State = BusinessEntity.States.Unmodified;
        }
    }
}
