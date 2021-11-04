using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Business.Entities;
using System;

namespace Data.Database
{
    public class PlanAdapter : Adapter
    {
        public List<Plan> GetAll()
        {
            try
            {
                using (AcademiaContext context = new AcademiaContext())
                {
                    return context.Plan.Include(p => p.Especialidad).ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception("No se pudieron recuperar los datos", e);
            }
        }

        public Plan GetOne(int id)
        {
            try
            {
                using (var context = new AcademiaContext())
                {
                    return context.Plan.Include(p => p.Especialidad).FirstOrDefault(p => p.ID == id);
                }
            }
            catch (Exception e)
            {
                throw new Exception("No se pudieron recuperar los datos", e);
            }
        }

        protected void Insert(Plan plan)
        {
            try
            {
                using (var context = new AcademiaContext())
                {
                    context.Especialidad.Attach(plan.Especialidad);
                    context.Plan.Add(plan);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception("No se pudieron insertar los datos", e);
            }
        }

        protected void Update(Plan plan)
        {
            try
            {
                using (var context = new AcademiaContext())
                {
                    context.Entry(plan).State = EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception("No se pudieron actualizar los datos", e);
            }
        }

        public void Delete(Plan plan)
        {
            try
            {
                using (var context = new AcademiaContext())
                {
                    context.Plan.Remove(context.Plan.Find(plan.ID));
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception("No se pudieron borrar los datos", e);
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
