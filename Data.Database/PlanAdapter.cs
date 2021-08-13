using System.Collections.Generic;
using System.Linq;
using Business.Entities;

namespace Data.Database
{
    public class PlanAdapter : Adapter
    {
        public List<Plan> GetAll()
        {
            using (AcademiaEntities context = new AcademiaEntities())
            {
                List<Plan> planes = new List<Plan>();
                context.planes
                    .ToList()
                    .ForEach(p => planes.Add(NuevoPlan(p)));
                return planes;
            }
        }

        public Plan GetOne(int id)
        {
            using (var context = new AcademiaEntities())
            {
                var plan = context.planes.FirstOrDefault(p => p.id_plan == id);
                return NuevoPlan(plan);
            }
        }

        public void Save(Plan plan)
        {
            if (plan.State == BusinessEntity.States.Deleted)
            {
                Delete(plan);
            }
            else if (plan.State == BusinessEntity.States.New)
            {
                Insert(plan);
            }
            else if (plan.State == BusinessEntity.States.Modified)
            {
                Update(plan);
            }
            plan.State = BusinessEntity.States.Unmodified;
        }

        public void Delete(Plan plan)
        {
            using (var context = new AcademiaEntities())
            {
                var pln = context.planes.FirstOrDefault(p => p.id_plan == plan.ID);
                if (pln != null)
                {
                    context.planes.Remove(pln);
                    context.SaveChanges();
                }
            }
        }

        protected void Update(Plan plan)
        {
            using (var context = new AcademiaEntities())
            {
                var pln = context.planes.FirstOrDefault(p => p.id_plan == plan.ID);
                if (pln != null)
                {
                    pln.desc_plan = plan.Descripcion;
                    pln.id_especialidad = plan.MiEspecialidad.ID;
                    context.SaveChanges();
                }
            }
        }

        protected void Insert(Plan plan)
        {
            using (var context = new AcademiaEntities())
            {
                planes pln = new planes
                {
                    id_plan = plan.ID,
                    desc_plan = plan.Descripcion,
                    id_especialidad = plan.MiEspecialidad.ID
                };
                context.planes.Add(pln);
                context.SaveChanges();
            }
        }

        private static Plan NuevoPlan(planes p)
        {
            if (p == null)
            {
                return null;
            }
            Plan plan = new Plan
            {
                ID = p.id_plan,
                Descripcion = p.desc_plan,
                MiEspecialidad = especialidadData.GetOne(p.especialidades.id_especialidad)
            };
            return plan;
        }
    }
}
