using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;

namespace Data.Database
{
    class PlanAdapter : Adapter
    {
        public List<Plan> GetAll()
        {
            using (AcademiaEntities db = new AcademiaEntities())
            {
                List<Plan> planes = new List<Plan>();
                var lstPlanes = db.planes;
                lstPlanes?.ToList().ForEach(p => planes.Add(nuevoPlan(p)));
                return planes;
            }
        }

        private static Plan nuevoPlan(planes plan)
        {
            Plan plan = new Plan()
            {
                ID_Plan = plan.ID_Plan,
                Descripcion = plan.Descripcion,
                ID_Especialidad = plan.ID_Especialidad,
            };
            if (plan.ID_Plan != null) plan.MiPlan = planData.GetOne((int)plan.ID_Plan);
            return plan;
        }

        public Plan GetOne(int ID)
        {
            using (var db = new AcademiaEntities())
            {
                var pln = db.planes.SingleOrDefault(p => p.ID_Plan == ID);
                if (pln == null) return null;
                return nuevoPlan(pln);
            }
        }

        public Plan GetOneNombreUsuario(string desc_plan)
        {
            using (var db = new AcademiaEntities())
            {
                var pln = db.planes.SingleOrDefault(p => p.Descripcion == desc_plan);
                if (pln == null) return null;
                return nuevoPlan(pln);
            }

        }

        public void Delete(int ID_Plan)
        {
            using (var db = new AcademiaEntities())
            {
                var pln = db.usuarios.SingleOrDefault(p => p.ID_Plan == ID_Plan);
                if (pln == null) return;
                db.planes.Remove(pln);
                db.SaveChanges();
            }
        }

        public void Save(Plan plan)
        {
            if (plan.State == BusinessEntity.States.Deleted)
            {
                this.Delete(plan.ID_Plan);
            }
            else if (plan.State == BusinessEntity.States.New)
            {
                this.Insert(plan);
            }
            else if (plan.State == BusinessEntity.States.Modified)
            {
                this.Update(plan);
            }
            plan.State = BusinessEntity.States.Unmodified;
        }

        protected void Update(Usuario usuario)
        {
            using (var db = new AcademiaEntities())
            {
                var pln = db.planes.SingleOrDefault(p => p.ID_Plan == planes.ID_Plan);
                if (pln == null) return;
                pln.Descripcion = planes.Descripcion;
                pln.id_especialidad = planes.ID_Especialidad;
                pln.id_plan = planes.MiPlan?.ID_Plan;
                db.SaveChanges();
            }
        }

        protected void Insert(Plan plan)
        {
            using (var db = new AcademiaEntities())
            {
                usuarios pln = new usuarios
                {
                    id_plan = plan.ID_Plan,
                    descripcion = plan.Descripcion,
                    id_especialidad = plan.ID_Especialidad
                };
                if (plan.MiPlan != null) pln.id_plan = plan.MiPlan.ID_Plan;

                db.planes.Add(pln);
                db.SaveChanges();
            }
        }
    }
}
