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
            catch (Exception ex)
            {
                throw new Exception("Error al recuperar los dictados.", ex);
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
            catch (Exception ex)
            {
                throw new Exception("Error al recuperar los dictados.", ex);
            }
        }

        public DocenteCurso GetOneByCurso(int id)
        {
            try
            {
                using (var context = new AcademiaContext())
                {
                    return context.DocenteCurso.Include(dc => dc.Curso.Comision).Include(dc => dc.Curso.Materia).Include(dc => dc.Docente).FirstOrDefault(i => i.Curso.ID == id);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al recuperar el dictado.", ex);
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
            catch (Exception ex)
            {
                throw new Exception("Error al recuperar el dictado.", ex);
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
            catch (Exception ex)
            {
                throw new Exception("Error al insertar el dictado.", ex);
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
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar el dictado.", ex);
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
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el dictado.", ex);
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
