using System.Collections.Generic;
using System.Linq;
using Business.Entities;
using System.Data.Entity;

namespace Data.Database
{
    public class CursoAdapter : Adapter
    {
        public List<Curso> GetAll()
        {
            using (AcademiaContext context = new AcademiaContext())
            {
                return context
                    .Curso
                    .Include(c => c.Materia)
                    .Include(c => c.Comision)
                    .ToList();
            }
        }

        public List<Curso> GetAllNoInscByPersona(int idPersona)
        {
            using (AcademiaContext context = new AcademiaContext())
            {
                var aux = context.Curso
                    .Include(c => c.Materia)
                    .Include(c => c.Comision)
                    .ToList()
                    .Where(c =>
                        !context.AlumnoInscripcion
                        .Where(i => i.AlumnoId.Equals(idPersona))
                        .Select(i => i.CursoId)
                        .Contains(c.ID))
                    .ToList();
                return aux;
            }
        }

        public Curso GetOne(int id)
        {
            using (var context = new AcademiaContext())
            {
                return context
                    .Curso
                    .Include(c => c.Materia)
                    .Include(c => c.Comision)
                    .FirstOrDefault(c => c.ID == id);
            }
        }

        protected void Insert(Curso curso)
        {
            using (var context = new AcademiaContext())
            {
                curso.Materia.Plan = context.Plan.Find(curso.Materia.PlanId);
                curso.Comision.Plan = context.Plan.Find(curso.Comision.PlanId);
                context.Comision.Attach(curso.Comision);
                context.Materia.Attach(curso.Materia);
                context.Curso.Add(curso);
                context.SaveChanges();
            }
        }

        protected void Update(Curso curso)
        {
            using (var context = new AcademiaContext())
            {
                curso.Materia.Plan = context.Plan.Find(curso.Materia.PlanId);
                curso.Comision.Plan = context.Plan.Find(curso.Comision.PlanId);
                context.Entry(curso).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(Curso curso)
        {
            using (var context = new AcademiaContext())
            {
                context.Curso.Remove(context.Curso.Find(curso.ID));
                context.SaveChanges();
            }
        }

        public void Save(Curso curso)
        {
            if (curso.State == BusinessEntity.States.New)
            {
                Insert(curso);
            }
            else if (curso.State == BusinessEntity.States.Modified)
            {
                Update(curso);
            }
            else if (curso.State == BusinessEntity.States.Deleted)
            {
                Delete(curso);
            }
            curso.State = BusinessEntity.States.Unmodified;
        }
    }
}
