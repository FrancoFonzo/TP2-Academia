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

        public List<AlumnoInscripcion> GetAllByAlumno(int id)
        {
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

        public List<AlumnoInscripcion> GetAllByCursos(int idCurso)
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

        public AlumnoInscripcion GetOne(int id)
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

        protected void Insert(AlumnoInscripcion inscripcion)
        {
            using (var context = new AcademiaContext())
            {
                context.Persona.Attach(inscripcion.Alumno);
                context.Curso.Attach(inscripcion.Curso);
                context.AlumnoInscripcion.Add(inscripcion);
                context.SaveChanges();
            }
        }

        protected void Update(AlumnoInscripcion inscripcion)
        {
            using (var context = new AcademiaContext())
            {
                context.Entry(inscripcion).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(AlumnoInscripcion inscripcion)
        {
            using (var context = new AcademiaContext())
            {
                context.AlumnoInscripcion.Remove(context.AlumnoInscripcion.Find(inscripcion.ID));
                context.SaveChanges();
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

        public int CountInscripcionesByCursos(int idCurso)
        {
            using (var context = new AcademiaContext())
            {
                int cantidad = context.AlumnoInscripcion.Where(i => i.CursoId == idCurso).Count();
                return (cantidad);
            }
        }
    }
}
