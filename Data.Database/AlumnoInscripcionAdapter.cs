using System.Collections.Generic;
using System.Linq;
using Business.Entities;
using System.Data.Entity;
using System;

namespace Data.Database
{
    public class AlumnoInscripcionAdapter : Adapter
    {
        public List<AlumnoInscripcion> GetAll()
        {
            try { 
                using (AcademiaContext context = new AcademiaContext())
                {
                    return context
                        .AlumnoInscripcion
                        .Include(i => i.Alumno)
                        .Include(i => i.Curso.Materia)
                        .Include(i => i.Curso.Comision)
                        .ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al recuperar las inscripciones.", ex);
            }
        }

        public List<AlumnoInscripcion> GetAllByAlumno(int id)
        {
            try { 
                using (var context = new AcademiaContext())
                {
                    return context
                        .AlumnoInscripcion
                        .Include(i => i.Alumno)
                        .Include(i => i.Curso.Materia)
                        .Include(i => i.Curso.Comision)
                        .Where(a => a.Alumno.ID == id)
                        .ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al recuperar las inscripciones.", ex);
            }
        }

        public List<AlumnoInscripcion> GetAllByCurso(int idCurso)
        {
            try
            {
                using (var context = new AcademiaContext())
                {
                    return context
                        .AlumnoInscripcion
                        .Include(i => i.Alumno)
                        .Include(i => i.Curso.Materia)
                        .Include(i => i.Curso.Comision)
                        .Where(a => a.Curso.ID == idCurso)
                        .ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al recuperar las inscripciones.", ex);
            }
        }

        public AlumnoInscripcion GetOne(int id)
        {
            try
            {
                using (var context = new AcademiaContext())
                {
                    return context
                        .AlumnoInscripcion
                        .Include(i => i.Alumno)
                        .Include(i => i.Curso.Materia)
                        .Include(i => i.Curso.Comision)
                        .FirstOrDefault(i => i.ID == id);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al recuperar la inscripcion.", ex);
            }
        }

        public int CountInscripcionesByCursos(int idCurso)
        {
            try
            {
                using (var context = new AcademiaContext())
                {
                    int cantidad = context.AlumnoInscripcion.Where(i => i.CursoId == idCurso).Count();
                    return (cantidad);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al contar las inscripciones.", ex);
            }
        }

        protected void Insert(AlumnoInscripcion inscripcion)
        {
            try
            {
                using (var context = new AcademiaContext())
                {
                    context.Persona.Attach(inscripcion.Alumno);
                    context.Curso.Attach(inscripcion.Curso);
                    context.AlumnoInscripcion.Add(inscripcion);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar la inscripcion.", ex);
            }
        }

        protected void Update(AlumnoInscripcion inscripcion)
        {
            try
            {
                using (var context = new AcademiaContext())
                {
                    context.Entry(inscripcion).State = EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar la inscripcion.", ex);
            }
        }

        public void Delete(AlumnoInscripcion inscripcion)
        {
            try
            {
                using (var context = new AcademiaContext())
                {
                    context.AlumnoInscripcion.Remove(context.AlumnoInscripcion.Find(inscripcion.ID));
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar la inscripcion.", ex);
            }
        }

        public void Save(AlumnoInscripcion insc)
        {
            if (insc.State == BusinessEntity.States.New)
            {
                Insert(insc);
            }
            else if (insc.State == BusinessEntity.States.Modified)
            {
                Update(insc);
            }
            else if (insc.State == BusinessEntity.States.Deleted)
            {
                Delete(insc);
            }
            insc.State = BusinessEntity.States.Unmodified;
        }
    }
}
