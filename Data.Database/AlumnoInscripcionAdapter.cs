﻿using System;
using System.Collections.Generic;
using System.Linq;
using Business.Entities;

namespace Data.Database
{
    public class AlumnoInscripcionAdapter : Adapter
    {
        public List<AlumnoInscripcion> GetAll()
        {
            using (AcademiaEntities context = new AcademiaEntities())
            {
                List<AlumnoInscripcion> inscripciones = new List<AlumnoInscripcion>();
                var lstInscripciones = context.alumnos_inscripciones;
                lstInscripciones?.ToList().ForEach(i => inscripciones.Add(nuevaInscripcion(i)));
                return inscripciones;
            }
        }

        public List<AlumnoInscripcion> GetAllAlumno(Persona alumno)
        {
            using (var context = new AcademiaEntities())
            {
                List<AlumnoInscripcion> inscripciones = new List<AlumnoInscripcion>();
                var lstInscripciones = context.alumnos_inscripciones.Where(i => i.id_alumno == alumno.ID);
                lstInscripciones?.ToList().ForEach(i => inscripciones.Add(nuevaInscripcion(i)));
                return inscripciones;
            }
        }

        public AlumnoInscripcion GetOne(int ID)
        {
            using (var context = new AcademiaEntities())
            {
                var insc = context.alumnos_inscripciones.SingleOrDefault(i => i.id_inscripcion == ID);
                return nuevaInscripcion(insc);
            }
        }

        public void Delete(int ID)
        {
            using (var context = new AcademiaEntities())
            {
                var insc = context.alumnos_inscripciones.SingleOrDefault(i => i.id_inscripcion == ID);
                if (insc != null)
                {
                    context.alumnos_inscripciones.Remove(insc);
                    context.SaveChanges();
                }
            }
        }

        public void Save(AlumnoInscripcion insc)
        {
            if (insc.State == BusinessEntity.States.Deleted)
            {
                Delete(insc.ID);
            }
            else if (insc.State == BusinessEntity.States.New)
            {
                Insert(insc);
            }
            else if (insc.State == BusinessEntity.States.Modified)
            {
                Update(insc);
            }
            insc.State = BusinessEntity.States.Unmodified;
        }

        protected void Update(AlumnoInscripcion inscripcion)
        {
            using (var context = new AcademiaEntities())
            {
                var insc = context.alumnos_inscripciones.SingleOrDefault(i => i.id_inscripcion == inscripcion.ID);
                if (insc != null)
                {
                    insc.id_inscripcion = inscripcion.ID;
                    insc.id_alumno = inscripcion.MiAlumno.ID;
                    insc.id_curso = inscripcion.MiCurso.ID;
                    insc.nota = inscripcion.Nota;
                    insc.condicion = inscripcion.Condicion.ToString();
                    context.SaveChanges();
                }
            }
        }

        protected void Insert(AlumnoInscripcion inscripcion)
        {
            using (var context = new AcademiaEntities())
            {
                alumnos_inscripciones insc = new alumnos_inscripciones
                {
                    id_inscripcion = inscripcion.ID,
                    id_alumno = inscripcion.MiAlumno.ID,
                    id_curso = inscripcion.MiCurso.ID,
                    condicion = inscripcion.Condicion.ToString(),
                    nota = inscripcion.Nota
                };
                context.alumnos_inscripciones.Add(insc);
                context.SaveChanges();
            }
        }

        private static AlumnoInscripcion nuevaInscripcion(alumnos_inscripciones insc)
        {
            if (insc == null)
            {
                return null;
            }
            AlumnoInscripcion inscripcion = new AlumnoInscripcion
            {
                ID = insc.id_inscripcion,
                Condicion = (AlumnoInscripcion.Condiciones) 
                    Enum.Parse(typeof(AlumnoInscripcion.Condiciones), insc.condicion),
                Nota = insc.nota,
                MiAlumno = personaData.GetOne(insc.id_alumno),
                MiCurso = cursoData.GetOne(insc.id_curso)
            };
            return inscripcion;
        }
    }
}
