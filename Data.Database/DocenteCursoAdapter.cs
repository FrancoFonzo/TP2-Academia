using System.Collections.Generic;
using Business.Entities;
using System.Linq;
using System.Data.Entity;

namespace Data.Database
{
    public class DocenteCursoAdapter : Adapter
    {
        public List<DocenteCurso> GetAll()
        {
            using (AcademiaContext context = new AcademiaContext())
            {
                return context.DocenteCurso.Include(dc => dc.Curso.Comision).Include(dc => dc.Curso.Materia).Include(dc => dc.Docente).ToList();
            }
        }

        public List<DocenteCurso> GetAllByDocente(int id)
        {
            using (var context = new AcademiaContext())
            {
                return context.DocenteCurso.Include(dc => dc.Curso.Comision).Include(dc => dc.Curso.Materia).Include(dc => dc.Docente).Where(i => i.Docente.ID == id).ToList();
            }
        }

        public DocenteCurso GetOneByCurso(int id)
        {
            using (var context = new AcademiaContext())
            {
                return context.DocenteCurso.Include(dc => dc.Curso.Comision).Include(dc => dc.Curso.Materia).Include(dc => dc.Docente).FirstOrDefault(i => i.Curso.ID == id);
            }
        }

        public DocenteCurso GetOne(int id)
        {
            using (var context = new AcademiaContext())
            {
                return context.DocenteCurso.Include(dc => dc.Curso.Comision).Include(dc => dc.Curso.Materia).Include(dc => dc.Docente).FirstOrDefault(i => i.ID == id);
            }
        }

        protected void Insert(DocenteCurso docenteCurso)
        {
            using (var context = new AcademiaContext())
            {
                context.Persona.Attach(docenteCurso.Docente);
                context.Curso.Attach(docenteCurso.Curso);
                context.DocenteCurso.Add(docenteCurso);
                context.SaveChanges();
            }
        }

        protected void Update(DocenteCurso docenteCurso)
        {
            using (var context = new AcademiaContext())
            {
                context.Entry(docenteCurso).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(DocenteCurso docenteCurso)
        {
            using (var context = new AcademiaContext())
            {
                context.DocenteCurso.Remove(context.DocenteCurso.Find(docenteCurso.ID));
                context.SaveChanges();
            }
        }

        public void Save(DocenteCurso docenteCurso)
        {
            if (docenteCurso.State == BusinessEntity.States.New)
            {
                Insert(docenteCurso);
            }
            else if (docenteCurso.State == BusinessEntity.States.Modified)
            {
                Update(docenteCurso);
            }
            else if (docenteCurso.State == BusinessEntity.States.Deleted)
            {
                Delete(docenteCurso);
            }
            docenteCurso.State = BusinessEntity.States.Unmodified;
        }
    }
}
