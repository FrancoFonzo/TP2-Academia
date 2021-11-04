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
            catch (Exception ex)
            {
                throw new Exception("Error al recuperar los planes.", ex);
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
            catch (Exception ex)
            {
                throw new Exception("Error al recuperar el plan.", ex);
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
            catch (Exception ex)
            {
                throw new Exception("Error al insertar el plan.", ex);
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
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar el plan.", ex);
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
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el plan.", ex);
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
