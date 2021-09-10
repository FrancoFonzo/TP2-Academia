using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Business.Entities;

namespace Data.Database
{
    public class PlanAdapter : Adapter
    {
        public List<Plan> GetAll()
        {
            using (AcademiaContext context = new AcademiaContext())
            {
                return context.Plan.Include(p => p.Especialidad).ToList();
            }
        }

        public Plan GetOne(int id)
        {
            using (var context = new AcademiaContext())
            {
                return context.Plan.Include(p => p.Especialidad).FirstOrDefault(p => p.ID == id);
            }
        }

        protected void Insert(Plan plan)
        {
            using (var context = new AcademiaContext())
            {
                context.Especialidad.Attach(plan.Especialidad);
                context.Plan.Add(plan);
                context.SaveChanges();
            }
        }

        protected void Update(Plan plan)
        {
            using (var context = new AcademiaContext())
            {
                context.Entry(plan).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(Plan plan)
        {
            using (var context = new AcademiaContext())
            {
                context.Plan.Remove(context.Plan.Find(plan.ID));
                context.SaveChanges();
            }
        }

        public void Save(Plan plan)
        {
            if (plan.State == BusinessEntity.States.New)
            {
                Insert(plan);
            }
            else if (plan.State == BusinessEntity.States.Modified)
            {
                Update(plan);
            }
            else if (plan.State == BusinessEntity.States.Deleted)
            {
                Delete(plan);
            }
            plan.State = BusinessEntity.States.Unmodified;
        }
    }
}
