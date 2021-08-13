using System.Collections.Generic;
using System.Linq;
using Business.Entities;

namespace Data.Database
{
    public class CursoAdapter : Adapter
    {
        public List<Curso> GetAll()
        {
            using (AcademiaEntities context = new AcademiaEntities())
            {
                List<Curso> cursos = new List<Curso>();
                context.cursos
                    .ToList()
                    .ForEach(c => cursos.Add(NuevoCurso(c)));
                return cursos;
            }
        }

        public List<Curso> GetCursosNoInscripto(int idPersona)
        {
            using (AcademiaEntities context = new AcademiaEntities())
            {
                List<Curso> cursos = new List<Curso>();
                context.cursos
                    .Where(c =>
                        !context.alumnos_inscripciones
                        .Where(i => i.id_alumno == idPersona)
                        .Select(i => i.id_curso)
                        .Contains(c.id_curso))
                    .ToList()
                    .ForEach(c => cursos.Add(NuevoCurso(c)));
                return cursos;
            }
        }

        public Curso GetOne(int id)
        {
            using (var context = new AcademiaEntities())
            {
                var cur = context.cursos.FirstOrDefault(c => c.id_curso == id);
                return NuevoCurso(cur);
            }
        }

        public void Delete(int id)
        {
            using (var context = new AcademiaEntities())
            {
                var cur = context.cursos.FirstOrDefault(c => c.id_curso == id);
                if (cur != null)
                {
                    context.Entry(cur).State = System.Data.Entity.EntityState.Deleted;
                    context.SaveChanges();
                }
            }
        }

        public void Save(Curso curso)
        {
            if (curso.State == BusinessEntity.States.Deleted)
            {
                Delete(curso.ID);
            }
            else if (curso.State == BusinessEntity.States.New)
            {
                Insert(curso);
            }
            else if (curso.State == BusinessEntity.States.Modified)
            {
                Update(curso);
            }
            curso.State = BusinessEntity.States.Unmodified;
        }

        protected void Update(Curso curso)
        {
            using (var context = new AcademiaEntities())
            {
                var cur = context.cursos.FirstOrDefault(c => c.id_curso == curso.ID);
                if (cur != null)
                {
                    cur.anio_calendario = curso.AnioCalendario;
                    cur.cupo = curso.Cupo;
                    cur.id_materia = curso.MiMateria.ID;
                    cur.id_comision = curso.MiComision.ID;
                    context.SaveChanges();
                }
            }
        }

        protected void Insert(Curso curso)
        {
            using (var context = new AcademiaEntities())
            {
                cursos cur = new cursos
                {
                    id_curso = curso.ID,
                    cupo = curso.Cupo,
                    anio_calendario = curso.AnioCalendario,
                    id_materia = curso.MiMateria.ID,
                    id_comision = curso.MiComision.ID
                };
                context.cursos.Add(cur);
                context.SaveChanges();
            }
        }

        private Curso NuevoCurso(cursos cur)
        {
            if (cur == null)
            {
                return null;
            }
            Curso curso = new Curso
            {
                ID = cur.id_curso,
                AnioCalendario = cur.anio_calendario,
                Cupo = cur.cupo,
                MiMateria = materiaData.GetOne(cur.id_materia),
                MiComision = comisionData.GetOne(cur.id_comision)
            };
            return curso;
        }
    }
}
