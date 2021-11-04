using System.Collections.Generic;
using System.Linq;
using Business.Entities;
using System.Data.Entity;
using System;

namespace Data.Database
{
    public class CursoAdapter : Adapter
    {
        public List<Curso> GetAll()
        {
            try
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
            catch (Exception ex)
            {
                throw new Exception("Error al recuperar los cursos.", ex);
            }
        }

        public List<Curso> GetAllNoInscByPersona(int idPersona)
        {
            try
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
            catch (Exception ex)
            {
                throw new Exception("Error al recuperar los cursos.", ex);
            }
        }

        public Curso GetOne(int id)
        {
            try
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
            catch (Exception ex)
            {
                throw new Exception("Error al recuperar el curso.", ex);
            }
        }

        protected void Insert(Curso curso)
        {
            try
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
            catch (Exception ex)
            {
                throw new Exception("Error al insertar el curso.", ex);
            }
        }

        protected void Update(Curso curso)
        {
            try
            {
                using (var context = new AcademiaContext())
                {
                    curso.Materia.Plan = context.Plan.Find(curso.Materia.PlanId);
                    curso.Comision.Plan = context.Plan.Find(curso.Comision.PlanId);
                    context.Entry(curso).State = EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar el curso.", ex);
            }
        }

        public void Delete(Curso curso)
        {
            try
            {
                using (var context = new AcademiaContext())
                {
                    context.Curso.Remove(context.Curso.Find(curso.ID));
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el curso.", ex);
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
