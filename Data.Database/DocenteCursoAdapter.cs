using System.Collections.Generic;
using Business.Entities;
using System.Linq;
using System.Data.Entity;
using System;

namespace Data.Database
{
    public class DocenteCursoAdapter : Adapter
    {
        public List<DocenteCurso> GetAll()
        {
            try
            {
                using (AcademiaContext context = new AcademiaContext())
                {
                    return context.DocenteCurso.Include(dc => dc.Curso.Comision).Include(dc => dc.Curso.Materia).Include(dc => dc.Docente).ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception("No se pudieron recuperar los datos", e);
            }
        }

        public List<DocenteCurso> GetAllByDocente(int id)
        {
            try
            {
                using (var context = new AcademiaContext())
                {
                    return context.DocenteCurso.Include(dc => dc.Curso.Comision).Include(dc => dc.Curso.Materia).Include(dc => dc.Docente).Where(i => i.Docente.ID == id).ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception("No se pudieron recuperar los datos", e);
            }
        }

        public DocenteCurso GetOneByCurso(int id)
        {
            try { 
            using (var context = new AcademiaContext())
            {
                return context.DocenteCurso.Include(dc => dc.Curso.Comision).Include(dc => dc.Curso.Materia).Include(dc => dc.Docente).FirstOrDefault(i => i.Curso.ID == id);
            }
            catch (Exception e)
            {
                throw new Exception("No se pudieron recuperar los datos", e);
            }
        }

        public DocenteCurso GetOne(int id)
        {
            try
            {
                using (var context = new AcademiaContext())
                {
                    return context.DocenteCurso.Include(dc => dc.Curso.Comision).Include(dc => dc.Curso.Materia).Include(dc => dc.Docente).FirstOrDefault(i => i.ID == id);
                }
            }
            catch (Exception e)
            {
                throw new Exception("No se pudieron recuperar los datos", e);
            }
        }

        protected void Insert(DocenteCurso docenteCurso)
        {
            try
            {
                using (var context = new AcademiaContext())
                {
                    context.Persona.Attach(docenteCurso.Docente);
                    context.Curso.Attach(docenteCurso.Curso);
                    context.DocenteCurso.Add(docenteCurso);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception("No se pudieron insertar los datos", e);
            }
        }

        protected void Update(DocenteCurso docenteCurso)
        {
            try
            {
                using (var context = new AcademiaContext())
                {
                    context.Entry(docenteCurso).State = EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception("No se pudieron actualizar los datos", e);
            }
        }

        public void Delete(DocenteCurso docenteCurso)
        {
            try
            {
                using (var context = new AcademiaContext())
                {
                    context.DocenteCurso.Remove(context.DocenteCurso.Find(docenteCurso.ID));
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception("No se pudieron borrar los datos", e);
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
