using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                var lstCursos = context.cursos;
                lstCursos?.ToList().ForEach(c => cursos.Add(nuevoCurso(c)));
                return cursos;
            }
        }

        private Curso nuevoCurso(cursos cur)
        {
            Curso curso = new Curso()
            {
                ID = cur.id_curso,
                AnioCalendario = cur.anio_calendario,
                Cupo = cur.cupo,
                MiMateria = materiaData.GetOne(cur.id_materia),
                MiComision = comisionData.GetOne(cur.id_comision)
            };
            curso.Descripcion = $"{curso.MiMateria.Descripcion}" +
                $" - {curso.MiComision.Descripcion} - {curso.AnioCalendario}";
            return curso;
        }

        public Curso GetOne(int ID)
        {
            using (var context = new AcademiaEntities())
            {
                var cur = context.cursos.SingleOrDefault(c => c.id_curso == ID);
                if (cur == null) return null;
                return nuevoCurso(cur);
            }

        }

        public void Delete(int ID)
        {
            using (var context = new AcademiaEntities())
            {
                var cur = context.cursos.SingleOrDefault(c => c.id_curso == ID);
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
                this.Delete(curso.ID);
            }
            else if (curso.State == BusinessEntity.States.New)
            {
                this.Insert(curso);
            }
            else if (curso.State == BusinessEntity.States.Modified)
            {
                this.Update(curso);
            }
            curso.State = BusinessEntity.States.Unmodified;
        }

        protected void Update(Curso curso)
        {
            using (var context = new AcademiaEntities())
            {
                var cur = context.cursos.SingleOrDefault(c => c.id_curso == curso.ID);
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
                cursos cur = new cursos()
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
    }
}