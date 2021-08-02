using System;
using System.Collections.Generic;
using System.Linq;
using Business.Entities;

namespace Data.Database
{
    public class AlumnoInscripcionAdapter : Adapter
    {
        public List<AlumnoInscripcion> GetAll()
        {
            using (AcademiaEntities db = new AcademiaEntities())
            {
                List<AlumnoInscripcion> inscripciones = new List<AlumnoInscripcion>();
                var lstInscripciones = db.alumnos_inscripciones;
                lstInscripciones?.ToList().ForEach(i => inscripciones.Add(nuevaInscripcion(i)));
                return inscripciones;
            }
        }

        private static AlumnoInscripcion nuevaInscripcion(alumnos_inscripciones insc)
        {
            AlumnoInscripcion inscripcion = new AlumnoInscripcion()
            {
                ID = insc.id_inscripcion,
                MiAlumno = personaData.GetOne(insc.id_alumno),
                MiCurso = personaData.GetOne(insc.id_curso),
                Condicion = insc.condicion,
                Nota = insc.nota
            };
            return inscripcion;
        }

        public AlumnoInscripcion GetOne(int ID)
        {
            using (var db = new AcademiaEntities())
            {
                var insc = db.alumnos_inscripciones.SingleOrDefault(i => i.id_inscripcion == ID);
                if (insc == null) return null;
                return nuevaInscripcion(insc);
            }
        }

        public void Delete(int ID)
        {
            using (var db = new AcademiaEntities())
            {
                var insc = db.alumnos_inscripciones.SingleOrDefault(i => i.id_inscripcion == ID);
                if (insc == null) return;
                db.alumnos_inscripciones.Remove(insc);
                db.SaveChanges();
            }
        }

        public void Save(AlumnoInscripcion insc)
        {
            if (insc.State == BusinessEntity.States.Deleted)
            {
                this.Delete(insc.ID);
            }
            else if (insc.State == BusinessEntity.States.New)
            {
                this.Insert(insc);
            }
            else if (insc.State == BusinessEntity.States.Modified)
            {
                this.Update(insc);
            }
            insc.State = BusinessEntity.States.Unmodified;
        }

        protected void Update(AlumnoInscripcion inscripcion)
        {
            using (var db = new AcademiaEntities())
            {
                var insc = db.alumnos_inscripciones.SingleOrDefault(i => i.id_inscripcion == inscripcion.ID);
                if (insc == null) return;
                insc.id_inscripcion = inscripcion.ID;
                insc.id_alumno = inscripcion.MiAlumno.ID;
                insc.id_curso = inscripcion.MiCurso.ID;
                insc.nota = (int) inscripcion.Nota;
                insc.condicion = inscripcion.Condicion;
                db.SaveChanges();
            }
        }

        protected void Insert(AlumnoInscripcion inscripcion)
        {
            using (var db = new AcademiaEntities())
            {
                alumnos_inscripciones insc = new alumnos_inscripciones
                {
                    id_inscripcion = inscripcion.ID,
                    id_alumno = inscripcion.MiAlumno.ID,
                    id_curso = inscripcion.MiCurso.ID,
                    condicion = inscripcion.Condicion,
                    nota = (int) inscripcion.Nota
                };
                db.alumnos_inscripciones.Add(insc);
                db.SaveChanges();
            }
        }
    }
}
